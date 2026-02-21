using DVLD.Properties;
using DVLD_Business;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DVLD.General;

namespace DVLD.People
{
    public partial class AddEditPerson : Form
    {
        public delegate void DataBackEventHandler(int personID);
        public event DataBackEventHandler DataBack;

        private enum Mode { Add, Edit};
        private Mode _mode;
        private Person person;
        public AddEditPerson()
        {
            InitializeComponent();
            person = new Person();
            _mode = Mode.Add;
        }
        public AddEditPerson(int personID)
        {
            InitializeComponent();
            person = Person.GetByID(personID);
            _mode = Mode.Edit;
        }
        private void InitializeDateOfBirth()
        {
            DateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            DateOfBirth.MinDate = DateTime.Today.AddYears(-100);
        }
        private void InitializeCountires()
        {
            DataTable countires = Country.GetAllCountries();

            Countries.DisplayMember = "CountryName";
            Countries.ValueMember = "CountryID";

            Countries.DataSource = countires;

            Countries.Text = "Saudi Arabia";
        }
        private void ChangeFormToEdit()
        {
            this.Text = "Edit Person";
            Title.Text = "Edit Person";
            TitleImage.Image = Resources.EditPerson_Image;
            Save.Text = "Update";
            Save.Image = Resources.EditPerson;
        }
        private void LoadPersonData()
        {
            if (person == null)
            {
                MessageBox.Show("Person not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ID.Text = person.PersonID.ToString();
            FirstName.Text = person.FirstName;
            SecondName.Text = person.SecondName;
            ThirdName.Text = person.ThirdName;
            LastName.Text = person.LastName;
            NationalNo.Text = person.NationalNo;
            DateOfBirth.Value = person.DateOfBirth;
            if (person.Gender == 0)
            {
                Male.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }
            Phone.Text = person.Phone;
            Email.Text = person.Email;
            Countries.SelectedValue = person.NationalityCountryID;
            Address.Text = person.Address;
            if (person.ImagePath != "")
            {
                Avatar.ImageLocation = person.ImagePath;
            }

            RemoveImage.Visible = person.ImagePath != "";
        }
        private void InitializeData()
        {
            InitializeDateOfBirth();
            InitializeCountires();

            if (_mode == Mode.Edit)
            {
                ChangeFormToEdit();
                LoadPersonData();
            }

        }
        private void AddEditPerson_Load(object sender, EventArgs e)
        {
            InitializeData();
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
        private void NationalNo_Validating(object sender, CancelEventArgs e)
        {
            ValidateNotEmpty(sender, e);

            if (e.Cancel) return;

            string nationalNo = NationalNo.Text.Trim();

            if (nationalNo != person.NationalNo && Person.ExistsByNationalNo(nationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(NationalNo, "National Number is used for another person!");
            }
            else
            {
                errorProvider1.SetError(NationalNo, "");
            }
        }
        private void Email_Validating(object sender, CancelEventArgs e)
        {
            string email = Email.Text.Trim();

            if (email != "" && !Validation.isValidEmail(email))
            {
                e.Cancel = true;
                errorProvider1.SetError(Email, "Email is not valid!");
            }
            else
            {
                errorProvider1.SetError(Email, null);
            }
        }
        private void ChangePicture(object sender, EventArgs e)
        {
            if (Avatar.ImageLocation != null) return;

            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                if (radioButton.Text == "Male")
                {
                    Avatar.Image = Resources.Male_Avatar;
                }
                else
                {
                    Avatar.Image = Resources.Female_Avatar;
                }
            }
        }
        private void SetImage_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = ImageFileDialog.FileName;
                Avatar.ImageLocation = selectedFilePath;
                RemoveImage.Visible = true;
            }
        }
        private void RemoveImage_Click(object sender, EventArgs e)
        {
            Avatar.ImageLocation = null;
            RemoveImage.Visible = false;

            Avatar.Image = Male.Checked ? Resources.Male_Avatar : Resources.Female_Avatar;
        }
        private bool HandlePersonImage()
        {
            if (person.ImagePath == Avatar.ImageLocation) return true;

            if (person.ImagePath != "")
            {
                Utility.DeleteFile(person.ImagePath);
            }
                
            string sourceFile = Avatar.ImageLocation;
            if (sourceFile != null)
            {
                if (Utility.CopyImageToProjectImagesFolder(ref sourceFile))
                {
                    Avatar.ImageLocation = sourceFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to copy image to project folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix validation errors!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!HandlePersonImage())
            {
                MessageBox.Show("Failed to handle person image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            person.FirstName = FirstName.Text.Trim();
            person.SecondName = SecondName.Text.Trim();
            person.ThirdName = ThirdName.Text.Trim();
            person.LastName = LastName.Text.Trim();
            person.NationalNo = NationalNo.Text.Trim();
            person.DateOfBirth = DateOfBirth.Value;
            person.Gender = Male.Checked ? Person.GenderType.Male : Person.GenderType.Female;
            person.Phone = Phone.Text.Trim();
            person.Email = Email.Text.Trim();
            person.NationalityCountryID = (int)Countries.SelectedValue;
            person.Address = Address.Text.Trim();
            if (Avatar.ImageLocation != null)
            {
                person.ImagePath = Avatar.ImageLocation;
            }
            else
            {
                person.ImagePath = "";
            }

            bool isNew = _mode == Mode.Edit;
            bool saved = person.Save();

            string action = isNew ? "add" : "update";
            string resultMessage = saved
                ? $"Person {(isNew ? "added" : "updated")} successfully!"
                : $"Failed to {action} person!";
            MessageBoxIcon icon = saved ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(resultMessage, saved ? "Success" : "Error", MessageBoxButtons.OK, icon);

            if (saved)
            {
                if (isNew)
                {
                    ID.Text = person.PersonID.ToString();
                    ChangeFormToEdit();
                }

                DataBack?.Invoke(person.PersonID);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
