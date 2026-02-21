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
    public partial class ScheduleTest : Form
    {
        private enum Mode { Add, Edit }
        private bool _isRetake;
        private Mode _mode;
        private LocalDrivingLicenseApplication _localApplication;
        private TestType.Type _testType;
        private int _testAppointmentID;
        public ScheduleTest(LocalDrivingLicenseApplication localApplication, TestType.Type type, bool isRetake = false)
        {
            InitializeComponent();
            _localApplication = localApplication;
            _testType = type;
            _isRetake = isRetake;
            _mode = Mode.Add;
        }
        public ScheduleTest(LocalDrivingLicenseApplication localApplication, TestType.Type type, int testAppointmentID)
        {
            InitializeComponent();
            _localApplication = localApplication;
            _testType = type;
            _testAppointmentID = testAppointmentID;
            _mode = Mode.Edit;
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            if (_mode == Mode.Add)
            {
                TestAppointmentCard.InitializeForAdd(_localApplication, _testType, _isRetake);
            }
            else
            {
                TestAppointmentCard.InitializeForEdit(_localApplication, _testType, _testAppointmentID);
            }
        }

        private void TestAppointmentCard_SaveClicked()
        {
            this.Close();
        }
    }
}
