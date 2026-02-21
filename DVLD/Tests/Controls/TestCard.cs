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

namespace DVLD.Tests.Controls
{
    public partial class TestCard : UserControl
    {
        public int TestID
        {
            set
            {
                ID.Text = value.ToString();
            }
        }
        public TestCard()
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
        public void LoadAppointment(int appointmentID)
        {
            TestAppointment testAppointment = TestAppointment.GetByID(appointmentID);

            if (testAppointment == null)
            {
                MessageBox.Show("Test Appointment not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   

            InitializeTitle((TestType.Type)testAppointment.TestTypeID);
            LocalApplicationID.Text = testAppointment.LocalDrivingLicenseApplicationID.ToString();
            LicenseClass.Text = testAppointment.LocalApplication.LicenseClass.Name;
            FullName.Text = testAppointment.LocalApplication.Application.ApplicantName;
            Trials.Text = Test.GetTrialsCountByTestType(testAppointment.LocalDrivingLicenseApplicationID, testAppointment.TestTypeID).ToString();
            Date.Text = testAppointment.Date.ToShortDateString();
            Fees.Text = testAppointment.PaidFees.ToString();
        }
    }
}
