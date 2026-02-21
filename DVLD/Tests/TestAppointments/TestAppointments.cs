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

namespace DVLD.Tests.TestAppointments
{
    public partial class TestAppointments : Form
    {
        DataView _testAppointments;
        private int _localApplicationID;
        private TestType.Type _testType;
        public TestAppointments(int localApplicationID, TestType.Type type)
        {
            InitializeComponent();
            _localApplicationID = localApplicationID;
            _testType = type;
        }
        private void InitializeTitles()
        {
            string title = "";

            switch (_testType)
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

            this.Text = title + ' ' + this.Text;
            Title.Text = title + ' ' + Title.Text;
        }
        private void LoadTestAppointments()
        {
            _testAppointments = TestAppointment.GetAllByApplicationAndTestType(_localApplicationID, _testType).DefaultView;
            TestAppointmentsList.DataSource = _testAppointments;
            NumberOfRecords.Text = _testAppointments.Count.ToString();
        }
        private void TestAppointments_Load(object sender, EventArgs e)
        {
            InitializeTitles();
            LocalApplicationCard.LoadLocalApplication(_localApplicationID);
            LoadTestAppointments();
        }
        private void ScheduleTest_Click(object sender, EventArgs e)
        {
            if (_testAppointments.Count > 0)
            {
                bool hasActiveAppointment = !Convert.ToBoolean(_testAppointments[0]["IsLocked"]);

                if (hasActiveAppointment)
                {
                    MessageBox.Show("The selected applicant already has an active appointment for this test. A new appointment cannot be scheduled.", "Active Appointment Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    int appointmentID = (int)_testAppointments[0]["ID"];

                    Test test = Test.GetByAppointmentID(appointmentID);
                    
                    if (test.IsPassed)
                    {
                        MessageBox.Show("The selected applicant has already passed this test. A new appointment cannot be scheduled.", "Test Already Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    ScheduleTest form = new ScheduleTest(LocalApplicationCard.LocalApplication, _testType, true);
                    form.ShowDialog();
                }

            }
            else
            {
                ScheduleTest form = new ScheduleTest(LocalApplicationCard.LocalApplication, _testType);
                form.ShowDialog();
            }

            LoadTestAppointments();
        }
        private bool EnsureAppointmentSelected(string message)
        {
            if (TestAppointmentsList.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Please select an appointment {message}.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected("to edit")) return;

            int id = (int) TestAppointmentsList.SelectedRows[0].Cells["ID"].Value;

            ScheduleTest form = new ScheduleTest(LocalApplicationCard.LocalApplication, _testType, id);
            form.ShowDialog();
            LoadTestAppointments();
        }
        private void TakeTest_Click(object sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected("to take test")) return;

            int id = (int)TestAppointmentsList.SelectedRows[0].Cells["ID"].Value;

            TakeTest form = new TakeTest(id);
            form.ShowDialog();
            LocalApplicationCard.RefreshPassedTests();
            LoadTestAppointments();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
