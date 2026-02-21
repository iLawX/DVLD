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

namespace DVLD.People
{
    public partial class ManagePeople : Form
    {
        private bool suppressFiltering;

        private DataView peopleDataView;
        public ManagePeople()
        {
            InitializeComponent();
        }
        private void LoadPeople()
        {
            peopleDataView = Person.GetAll().DefaultView;
            PeopleList.DataSource = peopleDataView;

            UpdateNumberOfRecords();
        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            LoadPeople();
            FilterCategories.Text = "None";
            PeopleList.ClearSelection();
        }
        private void ResetFilterControl()
        {
            Filter.Clear();
        }
        private void UpdateNumberOfRecords()
        {
            NumberOfRecords.Text = peopleDataView.Count.ToString();
        }
        private void ResetRowFilter()
        {
            peopleDataView.RowFilter = "";
            UpdateNumberOfRecords();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppressFiltering = true;

            string filterBy = FilterCategories.Text;

            Filter.Visible = filterBy != "None";

            ResetFilterControl();

            suppressFiltering = false;

            ResetRowFilter();

            if (Filter.Visible)
            {
                Filter.Focus();
            }
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterBy = FilterCategories.Text;

            if (filterBy == "PersonID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void ApplyTextFilter()
        {
            string filterBy = FilterCategories.Text;
            string filterValue = Filter.Text.Trim();

            if (filterValue == "")
            {
                ResetRowFilter();
                return;
            }

            if (filterBy == "PersonID")
            {
                peopleDataView.RowFilter = $"{filterBy} = {filterValue}";
            }
            else
            {
                peopleDataView.RowFilter = $"{filterBy} LIKE '%{filterValue}%'";
            }

            UpdateNumberOfRecords();
        }
        private void Filter_TextChanged(object sender, EventArgs e)
        {
            if (suppressFiltering)
            {
                return;
            }

            ApplyTextFilter();
        }
        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddEditPerson form = new AddEditPerson();
            form.ShowDialog();
            LoadPeople();

            int lastRowIndex = PeopleList.Rows.Count - 1;
            PeopleList.Rows[lastRowIndex].Selected = true;
        }
        private void ShowDetails()
        {
            if (PeopleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int personID = (int)PeopleList.SelectedRows[0].Cells["PersonID"].Value;
            PersonDetails form = new PersonDetails(personID);
            form.ShowDialog();
            LoadPeople();
        }
        private void PeopleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetails();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }
        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PeopleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = PeopleList.SelectedRows[0].Index;
            int personID = (int)PeopleList.SelectedRows[0].Cells["PersonID"].Value;

            AddEditPerson form = new AddEditPerson(personID);
            form.ShowDialog();
            LoadPeople();

            PeopleList.Rows[rowIndex].Selected = true;
        }
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PeopleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int personID = (int)PeopleList.SelectedRows[0].Cells["PersonID"].Value;

            Person person = Person.GetByID(personID);

            if (person == null)
            {
                MessageBox.Show("Person not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete this person [{personID}]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                if (Person.Delete(personID))
                {
                    MessageBox.Show("Person deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utility.DeleteFile(person.ImagePath);
                    LoadPeople();
                    PeopleList.ClearSelection();
                }
                else
                {
                    MessageBox.Show("This person cannot be deleted because it is linked to other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
