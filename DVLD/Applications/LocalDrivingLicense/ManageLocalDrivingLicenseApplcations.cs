using DVLD.Users;
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
using DVLD.Tests.TestAppointments;
using DVLD.Licenses;

namespace DVLD.Applications.LocalDrivingLicense
{
    public partial class ManageLocalDrivingLicenseApplcations : Form
    {
        DataView _localApplcations;
        private bool _suppressFiltering;
        public ManageLocalDrivingLicenseApplcations()
        {
            InitializeComponent();
        }
        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = _localApplcations.Count.ToString();
        }
        private void LoadLocalApplcations()
        {
            _localApplcations = LocalDrivingLicenseApplication.GetAll().DefaultView;
            LocalApplcationsList.DataSource = _localApplcations;
            LocalApplcationsList.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "ID";
            LocalApplcationsList.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Show all fullname
            ResetFilterControls();
            UpdateNumberOfRecords();
        }
        private void ManageLocalDrivingLicenseApplcations_Load(object sender, EventArgs e)
        {
            LoadLocalApplcations();

            FilterCategories.Text = "None";
            LocalApplcationsList.ClearSelection(); // Remove selection from first row
        }
        private void ResetFilterControls()
        {
            _suppressFiltering = true;
            Filter.Clear();
            ApplicationDate.Value = DateTime.Today;
            StatusList.SelectedIndex = 0;
            _suppressFiltering = false;
        }
        private void ResetRowFilter()
        {
            _localApplcations.RowFilter = "";
            UpdateNumberOfRecords();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterBy = FilterCategories.Text;

            ApplicationDate.Visible = filterBy == "ApplicationDate";
            StatusList.Visible = filterBy == "Status";
            Filter.Visible = !ApplicationDate.Visible && !StatusList.Visible && filterBy != "None";

            ResetFilterControls();

            ResetRowFilter();

            if (Filter.Visible)
            {
                Filter.Focus();
            }
            else if (ApplicationDate.Visible)
            {
                ApplicationDate.Focus(); 
            }
            else if (StatusList.Visible)
            {
                StatusList.Focus();
            }
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterBy = FilterCategories.Text;

            if (filterBy == "ID" || filterBy == "PassedTests")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private string GetFilter(string filterBy)
        {
            switch (filterBy)
            {
                case "ID":
                    return "LocalDrivingLicenseApplicationID";
                default:
                    return filterBy;
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

            string filterCategory = GetFilter(filterBy);

            if (filterBy == "ID" || filterBy == "PassedTests")
            {
                _localApplcations.RowFilter = $"{filterCategory} = {filterValue}";
            }
            else
            {
                _localApplcations.RowFilter = $"{filterCategory} LIKE '%{filterValue}%'";
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
        private void ApplyStatusFilter()
        {
            string filterValue = StatusList.Text;

            if (filterValue == "All")
            {
                ResetRowFilter();
                return;
            }

            _localApplcations.RowFilter = $"Status = '{filterValue}'";

            UpdateNumberOfRecords();
        }
        private void StatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressFiltering)
            {
                return;
            }

            ApplyStatusFilter();
        }
        private void ApplyApplicationDateFilter()
        {
            DateTime filterValue = ApplicationDate.Value.Date;
            DateTime nextDay = filterValue.AddDays(1);
            
            _localApplcations.RowFilter = $"ApplicationDate >= #{filterValue:MM/dd/yyyy}# AND ApplicationDate < #{nextDay:MM/dd/yyyy}#";

            UpdateNumberOfRecords();
        }
        private void ApplicationDate_ValueChanged(object sender, EventArgs e)
        {
            if (_suppressFiltering)
            {
                return;
            }

            ApplyApplicationDateFilter();
        }
        private void AddLocalApplication_Click(object sender, EventArgs e)
        {
            AddEditLocalDrivingLicenseApplication form = new AddEditLocalDrivingLicenseApplication();
            form.ShowDialog();
            LoadLocalApplcations();

            int lastRowIndex = LocalApplcationsList.Rows.Count - 1;
            LocalApplcationsList.Rows[lastRowIndex].Selected = true;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool EnsureApplicationSelected(string message)
        {
            if (LocalApplcationsList.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Please select an application {message}.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to show details")) return;

            int id = (int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value;

            ApplicationDetails form = new ApplicationDetails(id);
            form.ShowDialog();

            LoadLocalApplcations();
        }
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to edit")) return;

            int id = (int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value;

            AddEditLocalDrivingLicenseApplication form = new AddEditLocalDrivingLicenseApplication(id);
            form.ShowDialog();

            LoadLocalApplcations();
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to delete")) return;

            if (MessageBox.Show("Are you sure  you want to delete this local driving license application?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            int id = (int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value;

            LocalDrivingLicenseApplication localApplication = LocalDrivingLicenseApplication.GetByID(id);

            if (localApplication == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localApplication.Delete())
            {
                MessageBox.Show( "The local driving license application has been deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLocalApplcations();
            }
            else
            {
                MessageBox.Show("The application has related tests or completed procedures.", "Delete Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("To cancel")) return;

            if (MessageBox.Show("Are you sure you want to cancel this application?", "Cancel Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            int id = (int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value;

            LocalDrivingLicenseApplication localApplication = LocalDrivingLicenseApplication.GetByID(id);

            if (localApplication == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localApplication.Cancel())
            {
                MessageBox.Show("The application has been cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLocalApplcations();
            }
            else
            {
                MessageBox.Show("Failed to cancel the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ShowTestAppointments(TestType.Type type)
        {
            int id = (int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value;

            TestAppointments form = new TestAppointments(id, type);
            form.ShowDialog();
            LoadLocalApplcations();
        }
        private void VisionTest_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to schedule vision test")) return;

            ShowTestAppointments(TestType.Type.VistionTest);
        }
        private void WrittenTest_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to schedule written test")) return;

            ShowTestAppointments(TestType.Type.WrittenTest);
        }

        private void PracticalTest_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to schedule practical test")) return;

            ShowTestAppointments(TestType.Type.PracticalTest);
        }
        private void EnableDefaultActions()
        {
            ActionsMenu.Enabled = true;

            EditApplication.Enabled = true;
            DeleteApplication.Enabled = true;
            CancelApplication.Enabled = true;
            ScheduleTest.Enabled = true;
            ShowLicensesHistory.Enabled = true;

            IssueLicense.Enabled = false;
            ShowLicense.Enabled = false;

            VisionTest.Enabled = false;
            WrittenTest.Enabled = false;
            PracticalTest.Enabled = false;
        }
        private void DisableActionsMenu()
        {
            EditApplication.Enabled = false;
            DeleteApplication.Enabled = false;
            CancelApplication.Enabled = false;
            ScheduleTest.Enabled = false;
            IssueLicense.Enabled = false;
        }
        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {

            if (LocalApplcationsList.SelectedRows.Count == 0)
            {
                ActionsMenu.Enabled = false;
                return;
            }

            EnableDefaultActions();

            string status = LocalApplcationsList.SelectedRows[0].Cells["Status"].Value.ToString();

            switch (status)
            {
                case "New":
                    int passedTests = (int)LocalApplcationsList.SelectedRows[0].Cells["PassedTests"].Value;

                    if (passedTests > 0)
                    {
                        EditApplication.Enabled = false;
                        DeleteApplication.Enabled = false;
                    }

                    if (passedTests == 3)
                    {
                        ScheduleTest.Enabled = false;
                        IssueLicense.Enabled = true;
                        return;
                    }

                    if (passedTests == 0)
                    {
                        VisionTest.Enabled = true;
                    }
                    else if (passedTests == 1)
                    {
                        WrittenTest.Enabled = true;
                    }
                    else if (passedTests == 2)
                    {
                        PracticalTest.Enabled = true;
                    }

                    break;
                case "Cancelled":
                    DisableActionsMenu();
                    break;
                case "Completed":
                    DisableActionsMenu();
                    ShowLicense.Enabled = true;
                    break;
            }
        }

        private void IssueLicense_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to issue license")) return;

            IssueLocalDrivingLicense form = new IssueLocalDrivingLicense((int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            form.ShowDialog();

            LoadLocalApplcations();
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to show license")) return;

            LocalDrivingLicenseApplication localApplication = LocalDrivingLicenseApplication.GetByID((int)LocalApplcationsList.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);

            int licenseID = localApplication.GetLicenseID();

            LicenseDetails form = new LicenseDetails(licenseID);
            form.ShowDialog();
        }

        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            if (!EnsureApplicationSelected("to show license history")) return;

            LicensesHistory form = new LicensesHistory(LocalApplcationsList.SelectedRows[0].Cells["NationalNo"].Value.ToString());
            form.ShowDialog();
        }
    }
}
