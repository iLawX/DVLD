using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class User
    {
        public int UserID { get; set; } = -1;
        public int PersonID { get; set; } = -1;
        public Person Person = new Person();
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
        public User()
        {

        }
        private User(int userID, int personID, string username, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            Username = username;
            Password = password;
            IsActive = isActive;
            Person = Person.GetByID(personID);
        }

        public static DataTable GetAllUsers()
        {
            return UserDAL.GetAllUsers();
        }
        public static User GetByID(int userID)
        {
            int personID = -1;
            string username = string.Empty, password = string.Empty;
            bool isActive = false;

            if (UserDAL.GetUserByUserID(userID, ref personID, ref username, ref password, ref isActive))
            {
                return new User(userID, personID, username, password, isActive);
            }

            return null;
        }
        public static User FindByPersonID(int personID)
        {
            int userID = -1;
            string username = string.Empty, password = string.Empty;
            bool isActive = false;

            if (UserDAL.GetUserByPersonID(ref userID, personID, ref username, ref password, ref isActive))
            {
                return new User(userID, personID, username, password, isActive);
            }

            return null;
        }
        public static User FindByUsernameAndPassword(string username, string password)
        {
            int userID = -1, personID = -1;
            bool isActive = false;

            if (UserDAL.GetUserByUsernameAndPassword(ref userID, ref personID, username, password, ref isActive))
            {
                return new User(userID, personID, username, password, isActive);
            }

            return null;
        }
        public bool Add()
        {
            UserID = UserDAL.Add(PersonID, Username, Password, IsActive);

            return UserID != -1;
        }
        public bool Update()
        {
            return UserDAL.Update(UserID, PersonID, Username, Password, IsActive);
        }
        public bool Save()
        {
            return UserID == -1 ? Add() : Update();
        }
        public static bool Delete(int userID)
        {
            return UserDAL.Delete(userID);
        }
        public static bool IsExist(int userID)
        {
            return UserDAL.IsExist(userID);
        }
        public static bool IsExist(string username)
        {
            return UserDAL.IsExist(username);
        }
        public static bool IsExist(string username, string password)
        {
            return UserDAL.IsExist(username, password);
        }
        public static bool IsExistByPersonID(int personID)
        {
            return UserDAL.IsExistByPersonID(personID);
        }
        public bool ChangePassword(string newPassword)
        {
            if (Password == newPassword) return false;

            if (UserDAL.ChangePassword(UserID, newPassword))
            {
                Password = newPassword;
                return true;
            }

            return false;
        }
    }
}