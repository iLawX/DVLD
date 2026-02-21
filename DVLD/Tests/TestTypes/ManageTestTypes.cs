using DVLD.Applications;
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
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        void LoadTestTypes()
        {
            DataView testTypes = TestType.GetAll().DefaultView;
            TestTypesList.DataSource = testTypes;

            NumberOfRecords.Text = testTypes.Count.ToString();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
            TestTypesList.Columns["TestTypeDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TestTypesList.Columns["TestTypeTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void EditTestType()
        {
            if (TestTypesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a test type to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = TestTypesList.SelectedRows[0].Index;
            int id = (int)TestTypesList.SelectedRows[0].Cells["TestTypeID"].Value;

            EditTestType form = new EditTestType(id);
            form.ShowDialog();
            LoadTestTypes();

            TestTypesList.Rows[rowIndex].Selected = true;
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestType();
        }
        private void TestTypesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditTestType();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
