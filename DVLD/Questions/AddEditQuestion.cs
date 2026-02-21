using DVLD.General;
using DVLD.Questions.Choices;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.Questions
{
    public partial class AddEditQuestion : Form
    {
        private enum Mode { Add, Edit}
        private Mode _mode;
        private Question _question;
        public AddEditQuestion()
        {
            InitializeComponent();
            _question = new Question();
            _mode = Mode.Add;
        }
        public AddEditQuestion(int questionID)
        {
            InitializeComponent();
            _question = Question.GetByID(questionID);
            _mode = Mode.Edit;
        }

        private void InitializeTestTypes()
        {
            DataTable writtenTestTypes = LicenseClass.GetAll();

            TestType.DisplayMember = "ClassName";
            TestType.ValueMember = "LicenseClassID";
            TestType.DataSource = writtenTestTypes;
        }
        private void LoadQuestionData()
        {
            ID.Text = _question.ID.ToString();
            TestType.SelectedValue = _question.WrittenTestTypeID;
            QuestionText.Text = _question.Text;
            CreatedAt.Text = _question.CreatedAt.ToString();
            CreatedBy.Text = _question.CreatedByUser.Username;
        }
        private void LoadChoices()
        {
            DataTable questionChoices = _question.GetAllChoices();

            CorrectChoice.DisplayMember = "Text";
            CorrectChoice.ValueMember = "ID";
            CorrectChoice.DataSource = questionChoices;

            CorrectChoice.SelectedValue = _question.CorrectChoiceID;

            ChoicesList.DataSource = questionChoices;


            ChoicesList.Columns["CreatedAt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            NumberOfChoices.Text = questionChoices.Rows.Count.ToString();
        }
        private void ChangeFormToEdit()
        {
            this.Text = "Edit Question";
            CorrectChoice.Enabled = true;
            Add.Enabled = true;
        }
        private void AddEditQuestion_Load(object sender, EventArgs e)
        {
            InitializeTestTypes();

            if (_mode == Mode.Edit)
            {
                LoadQuestionData();
                LoadChoices();
                ChangeFormToEdit();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Question cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mode == Mode.Add)
            {
                _question.CreatedAt = DateTime.Now;
                _question.CreatedByUserID = Global.CurrentUser.UserID;
            }
            else if (_mode == Mode.Edit)
            {
                _question.CorrectChoiceID = Convert.ToInt32(CorrectChoice.SelectedValue);
            }

            _question.WrittenTestTypeID = (int)TestType.SelectedValue;
            _question.Text = QuestionText.Text;

            bool isNew = _mode == Mode.Add;
            bool saved = _question.Save();

            string action = isNew ? "add" : "update";
            string resultMessage = saved
                ? $"Question {(isNew ? "added" : "updated")} successfully!"
                : $"Failed to {action} question!";
            MessageBoxIcon icon = saved ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(resultMessage, saved ? "Success" : "Error", MessageBoxButtons.OK, icon);

            if (saved && isNew)
            {
                ID.Text = _question.ID.ToString();
                CreatedAt.Text = _question.CreatedAt.ToString();
                CreatedBy.Text = Global.CurrentUser.Username;
                ChangeFormToEdit();
                _mode = Mode.Edit;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewChoice()
        {
            AddEditChoice form = new AddEditChoice(_question.ID);
            form.ShowDialog();

            LoadChoices();
        }
        private void AddChoice_Click(object sender, EventArgs e)
        {
            AddNewChoice();
        }

        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {
            ActionsMenu.Enabled = ChoicesList.SelectedRows.Count > 0;
        }

        private void ShowChoiceDetails_Click(object sender, EventArgs e)
        {

        }

        private void AddChoice_Click_1(object sender, EventArgs e)
        {
            AddNewChoice();
        }

        private void EditChoice_Click(object sender, EventArgs e)
        {
            int choiceID = (int)ChoicesList.SelectedRows[0].Cells["ID"].Value;

            AddEditChoice form = new AddEditChoice(_question.ID, choiceID);
            form.ShowDialog();
            LoadChoices();
        }

        private void DeleteChoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this choice?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            int choiceID = (int)ChoicesList.SelectedRows[0].Cells["ID"].Value;

            if (QuestionChoice.Delete(choiceID))
            {
                MessageBox.Show("Choice deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChoices();
            }
            else
            {
                MessageBox.Show("Failed to delete the choice.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuestionText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuestionText.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(QuestionText, "This field can't be empty!");
            }
            else
            {
                errorProvider1.SetError(QuestionText, "");
            }
        }
    }
}
