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

namespace DVLD.Licenses.InternationalDrivingLicense.Controls
{
    public partial class NewInternationalLicenseCard : UserControl
    {
        private InternationalLicense _internationalLicense;
        public InternationalLicense InternationalLicense { get { return _internationalLicense; } }
        public NewInternationalLicenseCard()
        {
            InitializeComponent();
        }
        private void InternationalLicenseCard_Load(object sender, EventArgs e)
        {
            Fees.Text = ApplicationType.GetFeesByType(ApplicationType.Type.NewInternationalLicense).ToString();
            CreatedBy.Text = Global.CurrentUser.Username;
        }
        
        public void ResetCard()
        {
            ApplicationID.Text = "";
            InternationalLicenseID.Text = "";
            ApplicationDate.Text = "";
            LocalLicenseID.Text = "";
            IssueDate.Text = "";
            ExpirationDate.Text = "";
            Fees.Text = "";
            CreatedBy.Text = "";
        }
        private void LoadInternationalLicenseData()
        {
            if (_internationalLicense == null)
            {
                MessageBox.Show("International License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationID.Text = _internationalLicense.ApplicationID.ToString();
            InternationalLicenseID.Text = _internationalLicense.ID.ToString();
            ApplicationDate.Text = _internationalLicense.Application.Date.ToShortDateString();
            LocalLicenseID.Text = _internationalLicense.LocalDrivingLicenseID.ToString();
            IssueDate.Text = _internationalLicense.IssueDate.ToShortDateString();
            ExpirationDate.Text = _internationalLicense.ExpirationDate.ToShortDateString();
            Fees.Text = _internationalLicense.Application.PaidFees.ToString();
            CreatedBy.Text = _internationalLicense.Application.User.Username;
        }

        public void LoadInternationalLicense(int driverID)
        {
            _internationalLicense = InternationalLicense.GetByDriverID(driverID);

            LoadInternationalLicenseData();
        }
    }
}
