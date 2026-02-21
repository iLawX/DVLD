using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Licenses;
using DVLD.People;
using DVLD_Business;

namespace DVLD.Drivers
{
    public partial class ManageDrivers : Form
    {
        private DataView _driversList;
        private bool _suppressFiltering;
        public ManageDrivers()
        {
            InitializeComponent();
        }

        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = _driversList.Count.ToString();
        }
        private void LoadDriversList()
        {
            _driversList = Driver.GetAll().DefaultView;
            DriversList.DataSource = _driversList;
            DriversList.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            UpdateNumberOfRecords();
        }
        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            LoadDriversList();
            FilterCategories.SelectedIndex = 0;
            DriversList.ClearSelection();
        }

        private void ResetFilterControl()
        {
            Filter.Clear();
        }
        private void ResetRowFilter()
        {
            _driversList.RowFilter = "";
            UpdateNumberOfRecords();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _suppressFiltering = true;

            string filterBy = FilterCategories.Text;

            Filter.Visible = filterBy != "None";

            ResetFilterControl();

            _suppressFiltering = false;

            ResetRowFilter();

            if (Filter.Visible)
            {
                Filter.Focus();
            }
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterBy = FilterCategories.Text;

            if (filterBy == "DriverID" || filterBy == "PersonID")
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

            if (filterBy == "DriverID" || filterBy == "PersonID")
            {
                _driversList.RowFilter = $"{filterBy} = {filterValue}";
            }
            else
            {
                _driversList.RowFilter = $"{filterBy} LIKE '%{filterValue}%'";
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
        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DriversList.SelectedRows.Count == 0)
            {
                ActionsMenu.Enabled = false;
            }
            else
            {
                ActionsMenu.Enabled = true; 
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)DriversList.SelectedRows[0].Cells["PersonID"].Value;
            PersonDetails form = new PersonDetails(personID);
            form.ShowDialog();
        }
        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)DriversList.SelectedRows[0].Cells["PersonID"].Value;
            LicensesHistory form = new LicensesHistory(personID);
            form.ShowDialog();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
