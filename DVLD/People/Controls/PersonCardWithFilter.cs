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

namespace DVLD.People.Controls
{
    public partial class PersonCardWithFilter : UserControl
    {
        public event Action<int> SearchClicked;
        public int PersonID { get { return PersonCard.PersonID; } }
        public Person Person { get { return PersonCard.Person; } }
        public bool FilterEnabled { get { return FilterBox.Enabled; } set { FilterBox.Enabled = value; } }
        public PersonCardWithFilter()
        {
            InitializeComponent();
        }
        private void PersonCardWithFilter_Load(object sender, EventArgs e)
        {
            FilterCategories.SelectedIndex = 0; // Default to PersonID
            Filter.Focus();
        }
        private void FilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter.Clear();
            Filter.Focus();
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search.PerformClick();
            }

            string filterBy = FilterCategories.Text;

            if (filterBy == "PersonID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            string filterBy = FilterCategories.Text;
            string filterValue = Filter.Text.Trim();

            if (filterBy == "" || filterValue == "")
            {
                MessageBox.Show("Please select a filter category and enter a filter value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (filterBy == "PersonID")
            {
                PersonCard.LoadPerson(int.Parse(filterValue));
            }
            else
            {
                // National No
                PersonCard.LoadPerson(filterValue);
            }

            SearchClicked?.Invoke(PersonID);
        }
        public void LoadPerson(int personID)
        {
            FilterCategories.SelectedIndex = 0; // Default to PersonID
            Filter.Text = personID.ToString();
            PersonCard.LoadPerson(personID);
            SearchClicked?.Invoke(PersonID);
        }
        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddEditPerson form = new AddEditPerson();
            form.DataBack += LoadPerson;
            form.ShowDialog();
        }
    }
}