using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public static class UserDAL
    {
        public static DataTable GetAllUsers()
        {
            DataTable users = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Users_View;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                users.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return users;
        }
        public static bool GetUserByUserID(int userID, ref int personID, ref string username, ref string password, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Users
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    username = (string)reader["Username"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

                    isFound = true;
                }

                reader.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetUserByPersonID(ref int userID, int personID, ref string username, ref string password, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Users
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userID = (int)reader["UserID"];
                    username = (string)reader["Username"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

                    isFound = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close(); 
            }

            return isFound;
        }
        public static bool GetUserByUsernameAndPassword(ref int userID, ref int personID, string username, string password, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Users
                             WHERE Username = @Username AND Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    isActive = (bool)reader["IsActive"];

                    isFound = true;
                }

                reader.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int Add(int personID, string username, string password, bool isActive)
        {
            int userID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Users (PersonID, Username, Password, IsActive)
                             VALUES (@PersonID, @Username, @Password, @IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    userID = Convert.ToInt32(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return userID;
        }
        public static bool Update(int userID, int personID, string username, string password, bool isActive)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE Users
                             SET personID = @PersonID, Username = @Username, Password = @Password, IsActive = @IsActive
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }
        public static bool Delete(int userID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"DELETE FROM Users
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isDeleted = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return isDeleted;
        }
        public static bool IsExist(int userID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Users
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                isExist = command.ExecuteScalar() != null;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static bool IsExist(string username)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Users
                             WHERE Username = @Username;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();

                isExist = command.ExecuteScalar() != null;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static bool IsExist(string username, string password)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Users
                             WHERE Username = @Username AND Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();

                isExist = command.ExecuteScalar() != null;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static bool IsExistByPersonID(int personID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Users
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                isExist = command.ExecuteScalar() != null;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static bool ChangePassword(int userID, string password)
        {
            bool isChanged = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE Users
                             SET Password = @Password
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isChanged = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return isChanged;
        }
    }
}