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

namespace DVLD.Tests.WrittenTestTypes
{
    public partial class EditWrittenTestType : Form
    {
        private WrittenTestType _writtenTestType;
        public EditWrittenTestType(int id)
        {
            InitializeComponent();
            _writtenTestType = WrittenTestType.GetByID(id);
        }

        private void LoadWrittenTestTypeData()
        {
            if (_writtenTestType == null)
            {
                MessageBox.Show("Written Test Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ID.Text = _writtenTestType.ID.ToString();
            DurationInMinutes.Value = _writtenTestType.DurationInMinutes;
            NumberOfQuestions.Maximum = _writtenTestType.GetQuestionsCount();
            NumberOfQuestions.Value = _writtenTestType.NumberOfQuestions;
            PassPercentage.Value = _writtenTestType.PassPercentage;

        }
        private void EditWrittenTestType_Load(object sender, EventArgs e)
        {
            LoadWrittenTestTypeData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            _writtenTestType.DurationInMinutes = (int)DurationInMinutes.Value;
            _writtenTestType.NumberOfQuestions = (int)NumberOfQuestions.Value;
            _writtenTestType.PassPercentage = PassPercentage.Value;

            if (_writtenTestType.Save())
            {
                MessageBox.Show(
                "Written test type was saved successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                "Failed to save the written test type.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
