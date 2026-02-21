using DVLD.Users;
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
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }
        private void UpdateApplicationTypes()
        {
            DataView applicatioTypes = ApplicationType.GetAllApplicationTypes().DefaultView;

            ApplicationTypesList.DataSource = applicatioTypes;
            NumberOfRecords.Text = applicatioTypes.Count.ToString();
        }
        private void ManageApplications_Load(object sender, EventArgs e)
        {
            UpdateApplicationTypes();
            ApplicationTypesList.Columns["ApplicationTypeTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void EditApplicationType()
        {
            if (ApplicationTypesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application type to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = ApplicationTypesList.SelectedRows[0].Index;
            int id = (int)ApplicationTypesList.SelectedRows[0].Cells["ApplicationTypeID"].Value;

            EditApplicationType form = new EditApplicationType(id);
            form.ShowDialog();
            UpdateApplicationTypes();

            ApplicationTypesList.Rows[rowIndex].Selected = true;
        }

        private void ApplicationTypesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditApplicationType();
        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationType();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
