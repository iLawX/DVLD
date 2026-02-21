using DVLD.Licenses;
using DVLD.Licenses.DetainLicense;
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

namespace DVLD.Applications.ReleaseDetainedLicense
{
    public partial class ManageDetainedLicenses : Form
    {
        private DataView _detainedLicenses;
        private bool _suppressFiltering;
        public ManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = _detainedLicenses.Count.ToString();
        }
        private void LoadDetainedLicenses()
        {
            _detainedLicenses = DetainedLicense.GetAll().DefaultView;
            DetainedLicensesList.DataSource = _detainedLicenses;

            DetainedLicensesList.Columns["DriverName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            UpdateNumberOfRecords();
        }
        private void ManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            LoadDetainedLicenses();
            DetainedLicensesList.ClearSelection();
            FilterCategories.SelectedIndex = 0;
        }

        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {

            if (DetainedLicensesList.SelectedRows.Count == 0)
            {
                ActionsMenu.Enabled = false;
                return;
            }

            ActionsMenu.Enabled = true;

            ReleaseLicense.Enabled = !(bool)DetainedLicensesList.SelectedRows[0].Cells["IsReleased"].Value;
        }

        private void ShowPersonDetails_Click(object sender, EventArgs e)
        {
            string nationalNo = (string)DetainedLicensesList.SelectedRows[0].Cells["NationalNo"].Value;
            PersonDetails form = new PersonDetails(nationalNo);
            form.ShowDialog();
        }

        private void ShowLicenseDetails_Click(object sender, EventArgs e)
        {
            int licenseID = (int)DetainedLicensesList.SelectedRows[0].Cells["LicenseID"].Value;
            LicenseDetails form = new LicenseDetails(licenseID);
            form.ShowDialog();
        }

        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            string nationalNo = (string)DetainedLicensesList.SelectedRows[0].Cells["NationalNo"].Value;
            LicensesHistory form = new LicensesHistory(nationalNo);
            form.ShowDialog();
        }

        private void ReleaseLicense_Click(object sender, EventArgs e)
        {
            int licenseID = (int)DetainedLicensesList.SelectedRows[0].Cells["LicenseID"].Value;
            ReleaseDetainedLicense form = new ReleaseDetainedLicense(licenseID);
            form.ShowDialog();

            LoadDetainedLicenses();
        }
        private void ResetFilterControls()
        {
            Filter.Clear();
            ReleaseList.SelectedIndex = 0;
        }
        private void ResetRowFilter()
        {
            _detainedLicenses.RowFilter = "";
            UpdateNumberOfRecords();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _suppressFiltering = true;

            string filterBy = FilterCategories.Text;

            Filter.Visible = filterBy != "None" && filterBy != "IsReleased";
            ReleaseList.Visible = filterBy == "IsReleased";

            ResetFilterControls();

            _suppressFiltering = false;

            ResetRowFilter();

            if (Filter.Visible)
            {
                Filter.Focus();
            }
            else if (ReleaseList.Visible)
            {
                ReleaseList.Focus();
            }
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterBy = FilterCategories.Text;

            if (filterBy == "ID" || filterBy == "LicenseID" || filterBy == "ReleaseApplicationID")
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

            if (filterBy == "ID" || filterBy == "LicenseID" || filterBy == "ApplicationID")
            {
                _detainedLicenses.RowFilter = $"{filterBy} = {filterValue}";
            }
            else
            {
                _detainedLicenses.RowFilter = $"{filterBy} LIKE '%{filterValue}%'";
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
        private void ApplyReleaseFilter()
        {
            string filterValue = ReleaseList.Text;

            if (filterValue == "All")
            {
                ResetRowFilter();
                return;
            }

            if (filterValue == "Yes")
            {
                _detainedLicenses.RowFilter = "IsReleased = 1";
            }
            else
            {
                _detainedLicenses.RowFilter = "IsReleased = 0";
            }

            UpdateNumberOfRecords();
        }
        private void ReleaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressFiltering)
            {
                return;
            }

            ApplyReleaseFilter();
        }

        private void Detain_Click(object sender, EventArgs e)
        {
            DetainLicense form = new DetainLicense();
            form.ShowDialog();

            LoadDetainedLicenses();
        }

        private void Release_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense form = new ReleaseDetainedLicense();
            form.ShowDialog();

            LoadDetainedLicenses();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
