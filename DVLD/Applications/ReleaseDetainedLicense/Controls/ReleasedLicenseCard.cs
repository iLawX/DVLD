using DVLD.General;
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

namespace DVLD.Applications.ReleaseDetainedLicense.Controls
{
    public partial class ReleasedLicenseCard : UserControl
    {
        private DetainedLicense _releasedLicense;
        public DetainedLicense ReleasedLicense { get { return _releasedLicense; } }
        public string ApplicationIDText { set { ApplicationID.Text = value; } }
        public ReleasedLicenseCard()
        {
            InitializeComponent();
        }

        private decimal CalculateTotalFees()
        {
            return Convert.ToDecimal(ApplicationFees.Text) + Convert.ToDecimal(FineFees.Text);
        }
        public void SetTotalFees()
        {
            TotalFees.Text = CalculateTotalFees().ToString("F2");
        }
        public void ResetCard()
        {
            DetainID.Text = "";
            LicenseID.Text = "";
            DetainDate.Text = "";
            CreatedBy.Text = "";
            FineFees.Text = "";
            TotalFees.Text = "";
            ApplicationID.Text = "";
        }
        private void LoadReleasedLicenseData()
        {
            if (_releasedLicense == null)
            {
                MessageBox.Show("Released license not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetainID.Text = _releasedLicense.ID.ToString();
            LicenseID.Text = _releasedLicense.LicenseID.ToString();
            DetainDate.Text = _releasedLicense.DetentionDate.ToShortDateString();
            CreatedBy.Text = _releasedLicense.DetainedByUser.Username;
            FineFees.Text = _releasedLicense.FineFees.ToString("F2");
            SetTotalFees();
        }
        public void LoadReleasedLicense(int licenseID)
        {
            _releasedLicense = DetainedLicense.GetByLicenseID(licenseID);

            LoadReleasedLicenseData();
        }

        private void ReleasedLicenseCard_Load(object sender, EventArgs e)
        {
            ApplicationFees.Text = ApplicationType.GetFeesByType(ApplicationType.Type.ReleaseDetainedLicense).ToString("F2");
        }
    }
}
