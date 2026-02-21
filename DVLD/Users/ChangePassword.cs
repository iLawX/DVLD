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

namespace DVLD.Users
{
    public partial class ChangePassword : Form
    {
        private User user = new User();
        public ChangePassword(int userID)
        {
            InitializeComponent();
            user.UserID = userID;
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            user = User.GetByID(user.UserID);

            if (user == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            UserCard.LoadUser(user.UserID);
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
        private void CurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateNotEmpty(sender, e);

            if (e.Cancel) return;

            if (CurrentPassword.Text != user.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(CurrentPassword, "The current password is incorrect!");
            }
            else
            {
                errorProvider1.SetError(CurrentPassword, "");
            }
        }
        private void NewPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateNotEmpty(sender, e);

            if (e.Cancel) return;

            string newPassword = NewPassword.Text.Trim();

            if (newPassword == user.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(NewPassword, "Please choose a new password that is different from your current one.");
            }
            else
            {
                errorProvider1.SetError(NewPassword, "");
            }
        }
        private void ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateNotEmpty(sender, e);

            if (e.Cancel) return;

            if (ConfirmPassword.Text.Trim() != NewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(ConfirmPassword, "Password do not match.");
            }
            else
            {
                errorProvider1.SetError(ConfirmPassword, "");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix validation errors!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = NewPassword.Text.Trim();

            if (user.ChangePassword(password))
            {
                MessageBox.Show("Password has been updated successfully.", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update the password.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}