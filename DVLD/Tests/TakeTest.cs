using DVLD.Applications.LocalDrivingLicense.Controls;
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

namespace DVLD.Tests
{
    public partial class TakeTest : Form
    {
        private enum Mode { Add, Edit}
        private Mode _mode;
        private int _appointmentID;
        private Test _test;
        public TakeTest(int appointmentID)
        {
            InitializeComponent();
            _appointmentID = appointmentID;
        }

        private void ChangeFormToEdit()
        {
            TakenTestMessage.Visible = true;
            DisableResult();
        }
        private void DisableResult()
        {
            Pass.Enabled = false;
            Fail.Enabled = false;
        }
        private void LoadTestData()
        {
            _test = Test.GetByAppointmentID(_appointmentID);

            if (_test != null)
            {
                ChangeFormToEdit();
                TestCard.TestID = _test.ID;
                if (_test.IsPassed)
                {
                    Pass.Checked = true;
                }
                else
                {
                    Fail.Checked = true;
                }
                Notes.Text = _test.Notes;
                _mode = Mode.Edit;
            }
            else
            {
                _test = new Test();
                _mode = Mode.Add;
            }
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            TestCard.LoadAppointment(_appointmentID);

            LoadTestData();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (_mode == Mode.Add)
            {
                if (MessageBox.Show("Are you sure you want to save the test? You won't be able to edit the test result!", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                _test.TestAppointmentID = _appointmentID;
                _test.IsPassed = Pass.Checked;
                _test.Notes = Notes.Text;
                _test.CreatedByUserID = Global.CurrentUser.UserID;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to save the notes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                _test.Notes = Notes.Text;
            }


            if (_test.Save())
            {
                MessageBox.Show("The test has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TestCard.TestID = _test.ID;
                ChangeFormToEdit();
            }
            else
            {
                MessageBox.Show("Failed to save the test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
