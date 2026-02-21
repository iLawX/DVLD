using DVLD.General;
using DVLD.Licenses;
using DVLD.Licenses.DetainLicense.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD.Applications.ReleaseDetainedLicense
{
    public partial class ReleaseDetainedLicense : Form
    {
        private int _licenseID = -1;
        public ReleaseDetainedLicense(int licenseID)
        {
            InitializeComponent();
            _licenseID = licenseID;
        }
        public ReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void LicenseCardWithFilter_SearchClicked(int licenseID)
        {
            Release.Enabled = false;
            ShowLicensesHistory.Enabled = licenseID != -1;
            ReleasedLicenseCard.ResetCard();

            if (licenseID == -1) return;

            if (!LicenseCardWithFilter.License.IsDetained())
            {
                MessageBox.Show("The selected license is not detained.", "Not Detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReleasedLicenseCard.LoadReleasedLicense(licenseID);

            Release.Enabled = true;
        }

        private void Release_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release the selected license?", "Confirm Release", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            int applicationID = LicenseCardWithFilter.License.Release(Global.CurrentUser.UserID);

            if (applicationID != -1)
            {
                MessageBox.Show("License released successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LicenseCardWithFilter.FilterEnabled = false;
                ReleasedLicenseCard.ApplicationIDText = applicationID.ToString();
                Release.Enabled = false;
                ShowLicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to release the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            LicenseDetails form = new LicenseDetails(LicenseCardWithFilter.LicenseID);
            form.ShowDialog();
        }

        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistory form = new LicensesHistory(LicenseCardWithFilter.License.Driver.PersonID);
            form.ShowDialog();
        }

        private void ReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_licenseID > 0)
            {
                LicenseCardWithFilter.LoadLicense(_licenseID);
                Release.Enabled = true;
                ShowLicensesHistory.Enabled = true;
            }
        }
    }
}
