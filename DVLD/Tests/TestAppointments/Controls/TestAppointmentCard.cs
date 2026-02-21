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

namespace DVLD.Tests.TestAppointments.Controls
{
    public partial class TestAppointmentCard : UserControl
    {
        public event Action SaveClicked;

        private enum Mode { Add, Edit };
        private Mode _mode;
        private bool _isRetake;
        private LocalDrivingLicenseApplication _localApplication;
        private TestAppointment _testAppointment;
        private TestType.Type _testType;

        public TestAppointmentCard()
        {
            InitializeComponent();
        }
        private void InitializeTitle(TestType.Type type)
        {
            string title = "";

            switch (type)
            {
                case TestType.Type.VistionTest:
                    title = "Vision";
                    break;
                case TestType.Type.WrittenTest:
                    title = "Written";
                    break;
                case TestType.Type.PracticalTest:
                    title = "Practical";
                    break;
            }

            AppointmentCard.Text = title + " Test";
        }
        private void LoadLocalApplicationData(LocalDrivingLicenseApplication localApplication, TestType.Type type)
        {
            InitializeTitle(type);
            _localApplication = localApplication;
            LocalApplicationID.Text = localApplication.ID.ToString();
            LicenseClass.Text = localApplication.LicenseClass.Name;
            FullName.Text = localApplication.Application.ApplicantName;
            Trials.Text = localApplication.GetTrialsCountByTestType(type).ToString();
        }
        private void CalculateTotalFees()
        {
            decimal totalFees = Convert.ToDecimal(Fees.Text) + Convert.ToDecimal(RetakeFees.Text);
            TotalFees.Text = totalFees.ToString();
        }
        private void InitializeForRetake(decimal retakeFees)
        {
            RetakeTestInfo.Enabled = true;
            AppointmentCard.Text = "Retake " + AppointmentCard.Text;
            RetakeFees.Text = retakeFees.ToString();

            CalculateTotalFees();
        }
        public void InitializeForAdd(LocalDrivingLicenseApplication localApplication, TestType.Type type, bool isRetake = false)
        {
            _mode = Mode.Add;
            _testAppointment = new TestAppointment();
            _testType = type;
            _isRetake = isRetake;

            LoadLocalApplicationData(localApplication, type);
            Date.MinDate = DateTime.Now;
            Fees.Text = TestType.GetFeesByType(type).ToString();

            if (isRetake)
            {
                InitializeForRetake(ApplicationType.GetFeesByType(ApplicationType.Type.RetakeTest));
            }
        }
        public void InitializeForEdit(LocalDrivingLicenseApplication localApplication, TestType.Type type, int testAppintmentID)
        {
            if (Test.ExistsByAppointmentID(testAppintmentID))
            {
                TakenTestMessage.Visible = true;
                Save.Enabled = false;
            }

            _mode = Mode.Edit;
            _testAppointment = TestAppointment.GetByID(testAppintmentID);

            LoadLocalApplicationData(localApplication, type);
            Date.MinDate = _testAppointment.Date < DateTime.Now ? _testAppointment.Date : DateTime.Now;
            Date.Value = _testAppointment.Date;
            Fees.Text = _testAppointment.PaidFees.ToString();

            if (_testAppointment.RetakeTestApplicationID > 0)
            {
                InitializeForRetake(_testAppointment.RetakeTestApplication.PaidFees);
                RetakeApplicationID.Text = _testAppointment.RetakeTestApplicationID.ToString();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Add)
            {
                _testAppointment.TestTypeID = (int)_testType;
                _testAppointment.LocalDrivingLicenseApplicationID = _localApplication.ID;
                _testAppointment.PaidFees = Convert.ToDecimal(Fees.Text);
                _testAppointment.CreatedByUserID = Global.CurrentUser.UserID;

                if (_isRetake)
                {
                    ApplicationBAL application = new ApplicationBAL();

                    application.PersonID = _localApplication.Application.PersonID;
                    application.Date = DateTime.Now;
                    application.TypeID = (int)ApplicationType.Type.RetakeTest;
                    application.Status = ApplicationBAL.ApplicationStatus.Completed;
                    application.LastStatusDate = DateTime.Now;
                    application.PaidFees = Convert.ToDecimal(RetakeFees.Text);
                    application.CreatedByUserID = Global.CurrentUser.UserID;

                    if (!application.Save()) return;

                    RetakeApplicationID.Text = application.ID.ToString();
                    _testAppointment.RetakeTestApplicationID = application.ID;
                }

            }

            _testAppointment.Date = Date.Value;

            bool isNew = _mode == Mode.Add;
            bool saved = _testAppointment.Save();

            string action = isNew ? "add" : "update";
            string resultMessage = saved
                ? $"The Test Appointment {(isNew ? "added" : "updated")} successfully!"
                : $"Failed to {action} Test Appointment!";
            MessageBoxIcon icon = saved ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(resultMessage, saved ? "Success" : "Error", MessageBoxButtons.OK, icon);

            if (saved && isNew)
            {
                _mode = Mode.Edit;
            }

            SaveClicked?.Invoke();
        }
    }
}
