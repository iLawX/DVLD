using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public static class PersonDAL
    {
        public static DataTable GetAll()
        {
            DataTable people = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM People_View;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                people.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return people;
        }
        public static bool GetByID(int personID, ref string nationalNo, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM People
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    nationalNo = (string)reader["NationalNo"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        thirdName = (string)reader["ThirdName"];
                    }
                    lastName = (string)reader["LastName"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (byte)reader["Gender"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        email = (string)reader["Email"];
                    }
                    nationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagePath = (string)reader["ImagePath"];
                    }

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
        public static bool GetByNationalNo(ref int personID, string nationalNo, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM People
                             WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        thirdName = (string)reader["ThirdName"];
                    }
                    lastName = (string)reader["LastName"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (byte)reader["Gender"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        email = (string)reader["Email"];
                    }
                    nationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagePath = (string)reader["ImagePath"];
                    }

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
        public static int Add(string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, byte gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            int personID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
                             VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            if (string.IsNullOrWhiteSpace(thirdName))
            {
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", thirdName);
            }
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            if (string.IsNullOrWhiteSpace(email))
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", email);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", imagePath);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    personID = Convert.ToInt32(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return personID;
        }
        public static bool Update(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, byte gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE People
                             SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            if (string.IsNullOrWhiteSpace(thirdName))
            {
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", thirdName);
            }
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            if (string.IsNullOrWhiteSpace(email))
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", email);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", imagePath);
            }

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
        public static bool Delete(int personID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"DELETE FROM People
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

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
        public static bool ExistsByPersonID(int personID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM People
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
        public static bool ExistsByNationalNo(string nationalNo)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM People
                             WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);

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
        public static string GetFullNameByID(int id)
        {
            string fullName = "";

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT CONCAT_WS(' ',FirstName, SecondName, ThirdName, LastName)
                             FROM People
                             WHERE PersonID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    fullName = result.ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return fullName;
        }
    }
}