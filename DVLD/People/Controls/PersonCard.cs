using DVLD.Properties;
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

namespace DVLD.People.Controls
{
    public partial class PersonCard : UserControl
    {
        private int _id = -1;
        public int PersonID { get { return _id; } }
        private Person _person;
        public Person Person { get { return _person; } }
        public PersonCard()
        {
            InitializeComponent();
        }
        public void ResetCard()
        {
            _id = -1;
            ID.Text = "";
            FirstName.Text = "";
            SecondName.Text = "";
            ThirdName.Text = "";
            LastName.Text = "";
            NationalNo.Text = "";
            DateOfBirth.Text = "";
            Gender.Text = "";
            Phone.Text = "";
            Email.Text = "";
            Country.Text = "";
            Address.Text = "";
            Avatar.Image = Resources.Male_Avatar;
        }
        private void LoadPersonData()
        {
            if (_person == null)
            {
                MessageBox.Show("Person not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetCard();
                return;
            }

            _id = _person.PersonID;
            ID.Text = _person.PersonID.ToString();
            FirstName.Text = _person.FirstName;
            SecondName.Text = _person.SecondName;
            ThirdName.Text = _person.ThirdName;
            LastName.Text = _person.LastName;
            NationalNo.Text = _person.NationalNo;
            DateOfBirth.Text = _person.DateOfBirth.ToString();
            Gender.Text = _person.Gender == 0 ? "Male" : "Female";
            Phone.Text = _person.Phone;
            Email.Text = _person.Email;
            Country.Text = _person.Nationality.CountryName;
            Address.Text = _person.Address;
            if (_person.ImagePath != "")
            {
                Avatar.ImageLocation = _person.ImagePath;
            }
            else
            {
                Avatar.Image = _person.Gender == 0 ? Resources.Male_Avatar : Resources.Female_Avatar;
            }
        }
        public void LoadPerson(int personID)
        {
            _person = Person.GetByID(personID);

            LoadPersonData();
        }
        public void LoadPerson(string nationalNo)
        {
            _person = Person.GetByNationalNo(nationalNo);

            LoadPersonData();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            AddEditPerson form = new AddEditPerson(_person.PersonID);
            form.DataBack += LoadPerson;
            form.ShowDialog();
        }
    }
}