using DVLD.General;
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

namespace DVLD.Questions.Choices
{
    public partial class AddEditChoice : Form
    {
        private enum Mode { Add, Edit };
        private Mode _mode;
        private QuestionChoice _choice;
        public AddEditChoice(int questionID, int choiceID = -1)
        {
            InitializeComponent();

            if (choiceID == -1)
            {
                _choice = new QuestionChoice
                {
                    QuestionID = questionID
                };
                _mode = Mode.Add;
            }
            else
            {
                _choice = QuestionChoice.GetByID(choiceID);
                _mode = Mode.Edit;
            }
        }

        private void LoadChoiceData()
        {
            if (_choice == null)
            {
                MessageBox.Show("Question Choice not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ID.Text = _choice.ID.ToString();
            QuestionID.Text = _choice.QuestionID.ToString();
            ChoiceText.Text = _choice.Text;
            DisplayOrder.Value = _choice.DisplayOrder;
            CreatedAt.Text = _choice.CreatedAt.ToString();
            CreatedBy.Text = _choice.CreatedByUser.Username;
        }
        private void ChangeFormToEdit()
        {
            this.Text = "Edit Choice";
        }
        private void AddEditChoice_Load(object sender, EventArgs e)
        {
            if (_mode == Mode.Edit)
            {
                LoadChoiceData();
                ChangeFormToEdit();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Choice cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mode == Mode.Add)
            {
                _choice.CreatedAt = DateTime.Now;
                _choice.CreatedByUserID = Global.CurrentUser.UserID;
            }

            _choice.Text = ChoiceText.Text;
            _choice.DisplayOrder = (int)DisplayOrder.Value;

            bool isNew = _mode == Mode.Add;
            bool saved = _choice.Save();

            string action = isNew ? "add" : "update";
            string resultMessage = saved
                ? $"Choice {(isNew ? "added" : "updated")} successfully!"
                : $"Failed to {action} choice!";
            MessageBoxIcon icon = saved ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(resultMessage, saved ? "Success" : "Error", MessageBoxButtons.OK, icon);

            if (saved && isNew)
            {
                ID.Text = _choice.ID.ToString();
                QuestionID.Text = _choice.QuestionID.ToString();
                CreatedAt.Text = _choice.CreatedAt.ToString();
                CreatedBy.Text = Global.CurrentUser.Username;
                ChangeFormToEdit();
                _mode = Mode.Edit;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoiceText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChoiceText.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(ChoiceText, "This field can't be empty!");
            }
            else
            {
                errorProvider1.SetError(ChoiceText, "");
            }
        }
    }
}
