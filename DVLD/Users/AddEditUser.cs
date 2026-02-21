using DVLD.People.Controls;
using DVLD.Properties;
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

namespace DVLD.Users
{
    public partial class AddEditUser : Form
    {
        bool allowTabChange = false;
        private User user = new User();
        public AddEditUser(int userID)
        {
            InitializeComponent();
            user.UserID = userID;
        }
        private void LoadUserData()
        {
            user = User.GetByID(user.UserID);

            if (user == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            PersonCardWithFilter.LoadPerson(user.PersonID);
            ID.Text = user.UserID.ToString();
            Username.Text = user.Username;
            Password.Text = user.Password;
            ConfirmPassword.Text = user.Password;
            IsActive.Checked = user.IsActive;
        }
        private void ChangeFormToEdit()
        {
            this.Text = "Edit User";
            Title.Text = "Edit User";
            TitleImage.Image = Resources.EditPerson_Image;
            Save.Text = "Update";
            PersonCardWithFilter.FilterEnabled = false;
            Save.Image = Resources.EditPerson;
            Next.Enabled = true;
            allowTabChange = true;
        }
        private void AddEditUser_Load(object sender, EventArgs e)
        {
            if (user.UserID != -1)
            {
                LoadUserData();
                ChangeFormToEdit();
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowTabChange)
            {
                e.Cancel = true;
            }
        }
        private void PersonCardWithFilter_SearchClick(int personID)
        {
            Next.Enabled = personID != -1;
            allowTabChange = personID != -1 && !User.IsExistByPersonID(personID);
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (!allowTabChange)
            {
                MessageBox.Show("A user already exists for this person.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedTab = UserInfo;
        }
        private void ValidateNotEmpty(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field can't be empty!");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }
        private void Username_Validating(object sender, CancelEventArgs e)
        {
            ValidateNotEmpty(sender, e);

            if (e.Cancel) return;
            
            string username = Username.Text.Trim();
            
            if (username != user.Username && User.IsExist(username))
            {
                e.Cancel = true;
                errorProvider1.SetError(Username, "This username is already taken.");
            }
            else
            {
                errorProvider1.SetError(Username, "");
            }
        }
        private void ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateNotEmpty(sender, e);

            if (e.Cancel) return;

            if (Password.Text != ConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(ConfirmPassword, "Password do not match.");
            }
            else
            {
                errorProvider1.SetError(ConfirmPassword, "");
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PersonInfo;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix validation errors!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.PersonID = PersonCardWithFilter.Person.PersonID;
            user.Username = Username.Text.Trim();
            user.Password = Password.Text.Trim();
            user.IsActive = IsActive.Checked;

            bool isNew = user.UserID == -1;
            bool saved = user.Save();

            string action = isNew ? "add" : "update";
            string resultMessage = saved
                ? $"User {(isNew ? "added" : "updated")} successfully!"
                : $"Failed to {action} user!";
            MessageBoxIcon icon = saved ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(resultMessage, saved ? "Success" : "Error", MessageBoxButtons.OK, icon);

            if (saved)
            {
                if (isNew)
                {
                    ID.Text = user.UserID.ToString();
                    ChangeFormToEdit();
                }
            }
        }
    }
}