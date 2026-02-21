using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.General;
using DVLD_Business;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense.Controls
{
    public partial class ReplacedLicenseCard : UserControl
    {
        private License _license;
        public License ReplacedLicense { get { return _license; } }
        public string OldLicenseText { set { OldLicenseID.Text = value; } }
        public string ApplicationFeesText { set { ApplicationFees.Text = value; } }
        public ReplacedLicenseCard()
        {
            InitializeComponent();
        }
        private void LoadReplacedLicenseData()
        {
            if (_license == null)
            {
                MessageBox.Show("Failed to load the replaced license data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationID.Text = _license.ApplicationID.ToString();
            ReplacedLicenseID.Text = _license.ID.ToString();
            ApplicationDate.Text = _license.Application.Date.ToShortDateString();
            ApplicationFees.Text = _license.Application.PaidFees.ToString("F2");
            CreatedBy.Text = _license.Application.User.Username;
        }
        public void LoadReplacedLicense(int licenseID)
        {
            _license = License.GetByID(licenseID);

            LoadReplacedLicenseData();
        }

        private void ReplacedLicenseCard_Load(object sender, EventArgs e)
        {
            ApplicationFees.Text = ApplicationType.GetFeesByType(ApplicationType.Type.ReplacementForDamagedDrivingLicense).ToString("F2");
            CreatedBy.Text = Global.CurrentUser.Username;
        }
    }
}
