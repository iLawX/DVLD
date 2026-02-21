using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.General;
using DVLD.Licenses;
using DVLD_Business;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class ReplaceLostOrDamagedLicense : Form
    {
        public ReplaceLostOrDamagedLicense()
        {
            InitializeComponent();
        }

        private void LicenseCardWithFilter_SearchClicked(int id)
        {
            Replace.Enabled = false;
            ShowLicensesHistory.Enabled = id != -1;

            if (id == -1) return;

            if (!LicenseCardWithFilter.License.IsActive)
            {
                MessageBox.Show("The selected license is not active and cannot be replaced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Replace.Enabled = true;
        }
        private void ReplaceFor_CheckedChanged(object sender, EventArgs e)
        {
            if (Damaged.Checked)
            {
                this.Text = "Replacement For Damaged License";
                ReplacedLicenseCard.ApplicationFeesText = ApplicationType.GetFeesByType(ApplicationType.Type.ReplacementForDamagedDrivingLicense).ToString("F2");
            }
            else if (Lost.Checked)
            {
                this.Text = "Replacement For Lost License";
                ReplacedLicenseCard.ApplicationFeesText = ApplicationType.GetFeesByType(ApplicationType.Type.ReplacementForLostDrivingLicense).ToString("F2");
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to replace the selected license?", "Confirm Replacement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            License.Reason reason = Damaged.Checked ? License.Reason.ReplacementForDamaged : License.Reason.ReplacementForLost;

            int replacedLicenseID = LicenseCardWithFilter.License.Replace(reason, Global.CurrentUser.UserID);

            if (replacedLicenseID != -1)
            {
                MessageBox.Show("The license has been successfully replaced.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LicenseCardWithFilter.FilterEnabled = false;
                ReplaceFor.Enabled = false;
                ReplacedLicenseCard.LoadReplacedLicense(replacedLicenseID);
                ReplacedLicenseCard.OldLicenseText = LicenseCardWithFilter.License.ID.ToString();
                Replace.Enabled = false;
                ShowLicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to replace the license. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowLicense_Click(object sender, EventArgs e)
        {
            LicenseDetails form = new LicenseDetails(ReplacedLicenseCard.ReplacedLicense.ID);
            form.ShowDialog();
        }
        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistory form = new LicensesHistory(LicenseCardWithFilter.License.Driver.PersonID);
            form.ShowDialog();
        }
    }
}
