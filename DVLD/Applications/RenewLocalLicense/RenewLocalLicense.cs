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

namespace DVLD.Applications.RenewLocalLicense
{
    public partial class RenewLocalLicense : Form
    {
        public RenewLocalLicense()
        {
            InitializeComponent();
        }

        private void LicenseCardWithFilter_SearchClicked(int id)
        {
            Renew.Enabled = false;
            ShowLicensesHistory.Enabled = id != -1;

            if (id == -1) return;

            RenewedLicenseCard.LicenseFeesText = LicenseCardWithFilter.License.LicenseClass.Fees.ToString("F2");
            RenewedLicenseCard.SetTotalFees();

            if (!LicenseCardWithFilter.License.IsActive)
            {
                MessageBox.Show("The license is not active and cannot be renewed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!LicenseCardWithFilter.License.IsExpired())
            {
                MessageBox.Show("The license is still valid and does not require renewal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renew.Enabled = true;
        }

        private void Renew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this local driving license?", "Confirm Renewal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            int renewedLicenseID = LicenseCardWithFilter.License.Renew(Global.CurrentUser.UserID, RenewedLicenseCard.NotesText.Trim());

            if (renewedLicenseID != -1)
            {
                MessageBox.Show("Local driving license renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LicenseCardWithFilter.FilterEnabled = false;
                RenewedLicenseCard.LoadRenewedLicense(renewedLicenseID);
                RenewedLicenseCard.OldLicenseText = LicenseCardWithFilter.License.ID.ToString();
                Renew.Enabled = false;
                ShowLicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to renew local driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            LicenseDetails form = new LicenseDetails(RenewedLicenseCard.RenewedLicense.ID);
            form.ShowDialog();
        }

        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistory form = new LicensesHistory(LicenseCardWithFilter.License.Driver.PersonID);
            form.ShowDialog();
        }
    }
}
