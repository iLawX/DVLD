using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Tests.WrittenTestTypes
{
    public partial class ManageWrittenTestTypes : Form
    {
        
        public ManageWrittenTestTypes()
        {
            InitializeComponent();
        }

        private void LoadWrittenTestTypes()
        {
            DataTable writtenTestTypes = WrittenTestType.GetAll();
            TestTypesList.DataSource = writtenTestTypes;

            TestTypesList.Columns["ClassName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            NumberOfRecords.Text = writtenTestTypes.Rows.Count.ToString();
        }
        private void ManageWrittenTestTypes_Load(object sender, EventArgs e)
        {
            LoadWrittenTestTypes();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)TestTypesList.SelectedRows[0].Cells["ID"].Value;

            EditWrittenTestType form = new EditWrittenTestType(id);
            form.ShowDialog();

            LoadWrittenTestTypes();
        }

        private void ActionsMenu_Opening(object sender, CancelEventArgs e)
        {
            ActionsMenu.Enabled = TestTypesList.SelectedRows.Count > 0;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
