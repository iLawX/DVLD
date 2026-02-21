using DVLD.General;
using DVLD.People;
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
    public partial class ManageUsers : Form
    {
        private bool suppressFiltering;
        private DataView usersDataView;
        public ManageUsers()
        {
            InitializeComponent();
        }
        private void UpdateUsersList()
        {
            DataTable users = User.GetAllUsers();
            usersDataView = users.DefaultView;
            UsersList.DataSource = usersDataView;

            UpdateNumberOfRecords();
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            UpdateUsersList();

            FilterCategories.Text = "None";
            UsersList.ClearSelection();

            UsersList.Columns["FullName"].MinimumWidth = 400;
        }
        private void ResetFilterControls()
        {
            Filter.Clear();
            ActiveList.SelectedIndex = 0;
        }
        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = usersDataView.Count.ToString();
        }
        private void ResetRowFilter()
        {
            usersDataView.RowFilter = "";
            UpdateNumberOfRecords();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppressFiltering = true;

            string filterBy = FilterCategories.Text;

            Filter.Visible = filterBy != "None" && filterBy != "IsActive";
            ActiveList.Visible = filterBy == "IsActive";

            ResetFilterControls();

            suppressFiltering = false;

            ResetRowFilter();

            if (Filter.Visible)
            {
                Filter.Focus();
            }
            else if (ActiveList.Visible)
            {
                ActiveList.Focus();
            }
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterBy = FilterCategories.Text;

            if (filterBy == "UserID" || filterBy == "PersonID")
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

            if (filterBy == "UserID" || filterBy == "PersonID")
            {
                usersDataView.RowFilter = $"{filterBy} = {filterValue}";
            }
            else
            {
                usersDataView.RowFilter = $"{filterBy} LIKE '%{filterValue}%'";
            }

            UpdateNumberOfRecords();
        }
        private void Filter_TextChanged(object sender, EventArgs e)
        {
            if (suppressFiltering)
            {
                return;
            }

            ApplyTextFilter();
        }
        private void ApplyActiveFilter()
        {
            string filterValue = ActiveList.Text;

            if (filterValue == "All")
            {
                ResetRowFilter();
                return;
            }

            if (filterValue == "Yes")
            {
                usersDataView.RowFilter = "IsActive = 1";
            }
            else
            {
                usersDataView.RowFilter = "IsActive = 0";
            }

            UpdateNumberOfRecords();
        }
        private void ActiveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressFiltering)
            {
                return;
            }

            ApplyActiveFilter();
        }
        private void AddNewUser()
        {
            AddEditUser form = new AddEditUser(-1);
            form.ShowDialog();
            UpdateUsersList();

            int lastRowIndex = UsersList.Rows.Count - 1;
            UsersList.Rows[lastRowIndex].Selected = true;
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
        private void ShowDetails()
        {
            if (UsersList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = (int)UsersList.SelectedRows[0].Cells["UserID"].Value;
            UserDetails form = new UserDetails(userID);
            form.ShowDialog();
            UpdateUsersList();
        }
        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }
        private void UsersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetails();
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsersList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = UsersList.SelectedRows[0].Index;
            int userID = (int)UsersList.SelectedRows[0].Cells["UserID"].Value;

            AddEditUser form = new AddEditUser(userID);
            form.ShowDialog();
            UpdateUsersList();

            UsersList.Rows[rowIndex].Selected = true;
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsersList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = (int)UsersList.SelectedRows[0].Cells["UserID"].Value;

            if (Global.CurrentUser.UserID == userID)
            {
                MessageBox.Show("You cannot delete the current user.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete this user [{userID}]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (User.Delete(userID))
                {
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateUsersList();
                    UsersList.ClearSelection();
                }
                else
                {
                    MessageBox.Show("This user cannot be deleted because it is linked to other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsersList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = UsersList.SelectedRows[0].Index;
            int userID = (int)UsersList.SelectedRows[0].Cells["UserID"].Value;

            ChangePassword form = new ChangePassword(userID);
            form.ShowDialog();
            UpdateUsersList();

            UsersList.Rows[rowIndex].Selected = true;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}