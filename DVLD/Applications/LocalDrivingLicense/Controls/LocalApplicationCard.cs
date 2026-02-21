using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalDrivingLicense.Controls
{
    public partial class LocalApplicationCard : UserControl
    {
        private LocalDrivingLicenseApplication _localApplication;
        public LocalDrivingLicenseApplication LocalApplication { get { return _localApplication; } }
        private int _licenseID = -1;
        public LocalApplicationCard()
        {
            InitializeComponent();
        }
        public void RefreshPassedTests()
        {
            PassedTests.Text = _localApplication.GetPassedTestsCount() + " / 3";
        }
        private void LoadLocalApplicationData()
        {
            if (_localApplication == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ID.Text = _localApplication.ID.ToString();
            LicenseClass.Text = _localApplication.LicenseClass.Name;
            PassedTests.Text = _localApplication.GetPassedTestsCount() + " / 3";
            _licenseID = _localApplication.GetLicenseID();
            ShowLicense.Enabled = _licenseID > 0;
            ApplicationCard.LoadApplication(_localApplication.ApplicationID);
        }
        public void LoadLocalApplication(int id)
        {
            _localApplication = LocalDrivingLicenseApplication.GetByID(id);

            LoadLocalApplicationData();
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            LicenseDetails form = new LicenseDetails(_licenseID);
            form.ShowDialog();
        }
    }
}
