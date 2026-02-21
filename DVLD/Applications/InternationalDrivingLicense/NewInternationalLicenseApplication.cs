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
using DVLD.General;
using DVLD.Licenses;
using DVLD.Licenses.InternationalDrivingLicense;

namespace DVLD.Applications.InternationalDrivingLicense
{
    public partial class NewInternationalLicenseApplication : Form
    {
        public NewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue international license for the selected license?", "Confirm Detention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            if (LicenseCardWithFilter.License.IssueInternationalLicense(Global.CurrentUser.UserID))
            {
                MessageBox.Show("International driving license issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LicenseCardWithFilter.FilterEnabled = false;
                InternationalLicenseCard.LoadInternationalLicense(LicenseCardWithFilter.License.DriverID);
                Issue.Enabled = false;
                ShowLicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to issue international driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LicenseCardWithFilter_SearchClicked(int licenseID)
        {
            Issue.Enabled = false;
            ShowLicensesHistory.Enabled = licenseID != -1;

            if (licenseID == -1) return;


            if (LicenseCardWithFilter.License.LicenseClassID != (int)LicenseClass.Class.OrdinaryDrivingLicense || LicenseCardWithFilter.License.IsExpired())
            {
                MessageBox.Show("The driver does not have a valid ordinary driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!LicenseCardWithFilter.License.IsActive)
            {
                MessageBox.Show("The selected license is not active and cannot be used to issue inernational license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InternationalLicense.ExistsByLocalLicenseID(licenseID))
            {
                MessageBox.Show("An international driving license has already been issued for this local driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LicenseCardWithFilter.FilterEnabled = false;
                InternationalLicenseCard.LoadInternationalLicense(LicenseCardWithFilter.License.DriverID);
                Issue.Enabled = false;
                ShowLicense.Enabled = true;
                return;
            }

            Issue.Enabled = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            InternationalLicenseDetails form = new InternationalLicenseDetails(InternationalLicenseCard.InternationalLicense.ID);
            form.ShowDialog();
        }

        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistory form = new LicensesHistory(LicenseCardWithFilter.License.Driver.PersonID);
            form.ShowDialog();
        }
    }
}
