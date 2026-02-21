using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Questions
{
    public partial class ManageQuestions : Form
    {
        private DataView _questions;
        private bool _suppressFiltering;
        string filterCategory = "None";
        string filterValue;
        public ManageQuestions()
        {
            InitializeComponent();
        }

        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = _questions.Count.ToString();
        }
        private void GetLastFilter()
        {
            if (filterCategory == "None") return;

            if (filterCategory == "ID" || filterCategory == "CreatedByUserID")
            {
                _questions.RowFilter = $"{filterCategory} = {filterValue}";
            }
            else
            {
                _questions.RowFilter = $"{filterCategory} LIKE '%{filterValue}%'";
            }

            filterCategory = "None";
            filterValue = "";
        }
        private void LoadQuestions()
        {
            _questions = Question.GetAll().DefaultView;
            QuestionsList.DataSource = _questions;

            QuestionsList.Columns["Question"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            QuestionsList.Columns["Answer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GetLastFilter();

            UpdateNumberOfRecords();
        }
        private void ManageQuestions_Load(object sender, EventArgs e)
        {
            LoadQuestions();
            FilterCategories.SelectedIndex = 0;
            QuestionsList.ClearSelection();
        }

        private void ResetFilterControls()
        {
            Filter.Clear();
            TypeList.SelectedIndex = 0;
        }
        private void ResetRowFilter()
        {
            _questions.RowFilter = "";
            UpdateNumberOfRecords();
        }

        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _suppressFiltering = true;

            string filterBy = FilterCategories.Text;

            Filter.Visible = filterBy != "None" && filterBy != "WrittenTestType";
            TypeList.Visible = filterBy == "WrittenTestType";

            ResetFilterControls();

            _suppressFiltering = false;

            ResetRowFilter();

            if (Filter.Visible)
            {
                Filter.Focus();
            }
            else if (TypeList.Visible)
            {
                TypeList.Focus();
            }
        }

        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterBy = FilterCategories.Text;

            if (filterBy == "ID" || filterBy == "CreatedByUserID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void ApplyTextFilter()
        {
            string filterBy = FilterCategories.Text;
            string filterValue = Filter.Text.Trim();

            if (filterValue == "")
            {
                ResetRowFilter();
                return;
            }


            if (filterBy == "ID" || filterBy == "CreatedByUserID")
            {
                _questions.RowFilter = $"{filterBy} = {filterValue}";
            }
            else
            {
                _questions.RowFilter = $"{filterBy} LIKE '%{filterValue}%'";
            }

            UpdateNumberOfRecords();
        }
        private void Filter_TextChanged(object sender, EventArgs e)
        {
            if (_suppressFiltering)
            {
                return;
            }

            ApplyTextFilter();
        }

        private void ApplyTypeFilter()
        {
            string filterValue = TypeList.Text;

            if (filterValue == "All")
            {
                ResetRowFilter();
                return;
            }

            _questions.RowFilter = $"WrittenTestType = '{filterValue}'";

            UpdateNumberOfRecords();
        }
        private void TypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressFiltering)
            {
                return;
            }

            ApplyTypeFilter();
        }

        private void SaveFilter()
        {
            filterCategory = FilterCategories.Text;
            if (Filter.Visible)
            {
                filterValue = Filter.Text.Trim();
            }
            else if (TypeList.Visible)
            {
                filterValue = TypeList.Text;
            }
        }
        private void AddNewQuestion()
        {
            AddEditQuestion form = new AddEditQuestion();
            form.ShowDialog();

            SaveFilter();

            LoadQuestions();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddNewQuestion();
        }
        private void ShowQuestionDetails_Click(object sender, EventArgs e)
        {

        }
        private void AddQuestion_Click(object sender, EventArgs e)
        {
            AddNewQuestion();
        }

        private void EditQuestion_Click(object sender, EventArgs e)
        {
            int questionID = (int)QuestionsList.SelectedRows[0].Cells["ID"].Value;

            AddEditQuestion form = new AddEditQuestion(questionID);
            form.ShowDialog();

            SaveFilter();

            LoadQuestions();
        }

        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {
            ActionsMenu.Enabled = QuestionsList.SelectedRows.Count > 0;
        }

        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this question? All associated choices will be permanently removed.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            int questionID = (int)QuestionsList.SelectedRows[0].Cells["ID"].Value;

            if (Question.Delete(questionID))
            {
                MessageBox.Show("The question was deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFilter();
                LoadQuestions();
            }
            else
            {
                MessageBox.Show("The question could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
