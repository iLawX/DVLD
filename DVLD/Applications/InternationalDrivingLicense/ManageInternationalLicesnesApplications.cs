using DVLD.Licenses;
using DVLD.Licenses.InternationalDrivingLicense;
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

namespace DVLD.Applications.InternationalDrivingLicense
{
    public partial class ManageInternationalLicesnesApplications : Form
    {
        private DataView _internationalApplications;
        private bool _suppressFiltering;
        public ManageInternationalLicesnesApplications()
        {
            InitializeComponent();
        }


        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = _internationalApplications.Count.ToString();
        }
        private void LoadInternationalApplications()
        {
            _internationalApplications = InternationalLicense.GetAll().DefaultView;
            InternationalApplicationsList.DataSource = _internationalApplications;


            UpdateNumberOfRecords();
        }
        private void ManageInternationalLicesnesApplications_Load(object sender, EventArgs e)
        {
            LoadInternationalApplications();
            InternationalApplicationsList.ClearSelection();
            FilterCategories.SelectedIndex = 0;
        }
        private void AddInternationalApplication_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication form = new NewInternationalLicenseApplication();
            form.ShowDialog();

            LoadInternationalApplications();
        }
        private void ResetFilterControls()
        {
            Filter.Clear();
            ActiveList.SelectedIndex = 0;
        }
        private void ResetRowFilter()
        {
            _internationalApplications.RowFilter = "";
            UpdateNumberOfRecords();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _suppressFiltering = true;

            string filterBy = FilterCategories.Text;

            Filter.Visible = filterBy != "None" && filterBy != "IsActive";
            ActiveList.Visible = filterBy == "IsActive";

            ResetFilterControls();

            _suppressFiltering = false;

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

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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


            _internationalApplications.RowFilter = $"{filterBy} = {filterValue}";

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
                _internationalApplications.RowFilter = "IsActive = 1";
            }
            else
            {
                _internationalApplications.RowFilter = "IsActive = 0";
            }

            UpdateNumberOfRecords();
        }
        private void ActiveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressFiltering)
            {
                return;
            }

            ApplyActiveFilter();
        }
        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {
            ActionsMenu.Enabled = InternationalApplicationsList.SelectedRows.Count > 0;
        }

        private void ShowPersonDetails_Click(object sender, EventArgs e)
        {
            int driverID = (int)InternationalApplicationsList.SelectedRows[0].Cells["DriverID"].Value;
            Driver driver = Driver.GetByID(driverID);

            PersonDetails form = new PersonDetails(driver.PersonID);
            form.ShowDialog();
        }

        private void ShowLicenseDetails_Click(object sender, EventArgs e)
        {
            int internationalLicenseID = (int)InternationalApplicationsList.SelectedRows[0].Cells["ID"].Value;
            InternationalLicenseDetails form = new InternationalLicenseDetails(internationalLicenseID);
            form.ShowDialog();
        }

        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            int driverID = (int)InternationalApplicationsList.SelectedRows[0].Cells["DriverID"].Value;
            Driver driver = Driver.GetByID(driverID);

            LicensesHistory form = new LicensesHistory(driver.PersonID);
            form.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
