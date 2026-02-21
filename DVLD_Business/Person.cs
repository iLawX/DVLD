using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class Person
    {
        public enum GenderType { Male = 0, Female = 1};
        public int PersonID { get; set; } = -1;
        public string NationalNo { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string ThirdName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get { return GetFullName(); }  }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public GenderType Gender { get; set; } = GenderType.Male;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int NationalityCountryID { get; set; } = -1;
        public Country Nationality;
        public string ImagePath { get; set; } = string.Empty;
        public Person()
        {
            
        }
        private Person(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, GenderType gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            Nationality = Country.Find(NationalityCountryID);
            ImagePath = imagePath;
        }
        public static DataTable GetAll()
        {
            return PersonDAL.GetAll();
        }
        public static Person GetByID(int personID)
        {
            byte gender = 3;
            int nationalityCountryID = -1;
            string nationalNo = "", firstName = "", secondName = "", thirdName = "", lastName = "", address = "", phone = "", email = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;

            if (PersonDAL.GetByID(personID, ref nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new Person(personID, nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, (GenderType)gender, address, phone, email, nationalityCountryID, imagePath);
            }

            return null;
        }
        public static Person GetByNationalNo(string nationalNo)
        {
            byte gender = 3;
            int personID = -1, nationalityCountryID = -1;
            string firstName = "", secondName = "", thirdName = "", lastName = "", address = "", phone = "", email = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;

            if (PersonDAL.GetByNationalNo(ref personID, nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new Person(personID, nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, (GenderType)gender, address, phone, email, nationalityCountryID, imagePath);
            }

            return null;
        }
        public bool Add()
        {
            PersonID = PersonDAL.Add(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (byte)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            return PersonID != -1;
        }
        public bool Update()
        {
            return PersonDAL.Update(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (byte)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
        }
        public bool Save()
        {
            return PersonID < 1 ? Add() : Update();
        }
        public static bool Delete(int personID)
        {
            return PersonDAL.Delete(personID);
        }
        public static bool ExistsByPersonID(int personID)
        {
            return PersonDAL.ExistsByPersonID(personID);
        }
        public static bool ExistsByNationalNo(string nationalNo)
        {
            return PersonDAL.ExistsByNationalNo(nationalNo);
        }
        public static string GetFullNameByID(int personID)
        {
            return PersonDAL.GetFullNameByID(personID);
        }
        private string GetFullName()
        {
            return FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName;
        }
    }
}