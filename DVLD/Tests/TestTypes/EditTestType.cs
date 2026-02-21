using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class EditTestType : Form
    {
        TestType testType;
        public EditTestType(int id)
        {
            InitializeComponent();
            testType = TestType.GetByID(id);
        }
        private void LoadTestTypeData()
        {
            if (testType == null)
            {
                MessageBox.Show("Test Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ID.Text = testType.ID.ToString();
            Title.Text = testType.Title;
            Description.Text = testType.Description;
            Fees.Value = testType.Fees;
        }
        private void EditTestType_Load(object sender, EventArgs e)
        {
            LoadTestTypeData();
        }

        private void ValidateNotEmpty(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field can't be empty!");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix validation errors!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            testType.Title = Title.Text.Trim();
            testType.Description = Description.Text.Trim();
            testType.Fees = Fees.Value;

            if (testType.Save())
            {
                MessageBox.Show("Test type has been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update the Test type. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
