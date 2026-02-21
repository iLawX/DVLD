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

namespace DVLD.Applications
{
    public partial class EditApplicationType : Form
    {
        private ApplicationType applicationType;
        private int _id;
        public EditApplicationType(int id)
        {
            InitializeComponent();
            _id = id;
        }

        void LoadApplicationTypeData()
        {
            applicationType = ApplicationType.GetByID(_id);

            if (applicationType == null)
            {
                MessageBox.Show("Application Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ID.Text = applicationType.ID.ToString();
            Title.Text = applicationType.Title;
            Fees.Value = applicationType.Fees;
        }
        private void EditApplicationType_Load(object sender, EventArgs e)
        {
            LoadApplicationTypeData();
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

            applicationType.Title = Title.Text.Trim();
            applicationType.Fees = Fees.Value;

            if (applicationType.Save())
            {
                MessageBox.Show("Application type has been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update the application type. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
