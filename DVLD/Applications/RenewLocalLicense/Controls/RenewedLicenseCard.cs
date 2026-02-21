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

namespace DVLD.Applications.RenewLocalLicense.Controls
{
    public partial class RenewedLicenseCard : UserControl
    {
        public string OldLicenseText { set { OldLicenseID.Text = value; } }
        public string NotesText { set { Notes.Text = value; } get { return Notes.Text; } }
        public string LicenseFeesText { set { LicenseFees.Text = value; } }
        private License _license;
        public License RenewedLicense { get { return _license; } }
        public RenewedLicenseCard()
        {
            InitializeComponent();
        }

        private decimal CalculateTotalFees()
        {
            return Convert.ToDecimal(ApplicationFees.Text) + Convert.ToDecimal(LicenseFees.Text);
        }
        public void SetTotalFees()
        {
            TotalFees.Text = CalculateTotalFees().ToString("F2");
        }
        private void LoadRenewedLicenseData()
        {
            if (_license == null)
            {
                MessageBox.Show("Renewed License not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationID.Text = _license.ApplicationID.ToString();
            RenewedLicenseID.Text = _license.ID.ToString();
            ApplicationBAL application = ApplicationBAL.GetByID(_license.ApplicationID);
            ApplicationDate.Text = application.Date.ToShortDateString();
            IssueDate.Text = _license.IssueDate.ToShortDateString();
            ExpirationDate.Text = _license.ExpirationDate.ToShortDateString();
            ApplicationFees.Text = application.PaidFees.ToString("F2");
            CreatedBy.Text = application.User.Username;
            LicenseFees.Text = _license.PaidFees.ToString("F2");
            SetTotalFees();
            Notes.Text = _license.Notes;
        }
        public void LoadRenewedLicense(int licenseID)
        {
            _license = License.GetByID(licenseID);

            LoadRenewedLicenseData();
        }

        private void RenewedLicenseCard_Load(object sender, EventArgs e)
        {
            ApplicationFees.Text = ApplicationType.GetFeesByType(ApplicationType.Type.RenewDrivingLicense).ToString("F2");
            CreatedBy.Text = Global.CurrentUser.Username;
        }
    }
}
