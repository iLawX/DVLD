using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class TestDAL
    {
        public static bool GetByID(int id, ref int testAppointmentID, ref bool isPassed, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Tests
                             WHERE TestID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    testAppointmentID = (int)reader["TestAppointmentID"];
                    isPassed = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        notes = (string)reader["Notes"];
                    }
                    if (reader["CreatedByUserID"] != DBNull.Value)
                    {
                        createdByUserID = (int)reader["CreatedByUserID"];
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
        public static bool GetByAppointmentID(ref int id, int testappointmentID, ref bool isPassed, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Tests
                             WHERE TestAppointmentID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", testappointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["TestID"];
                    isPassed = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        notes = (string)reader["Notes"];
                    }
                    if (reader["CreatedByUserID"] != DBNull.Value)
                    {
                        createdByUserID = (int)reader["CreatedByUserID"];
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
        public static int Add(int testAppointmentID, bool isPassed, string notes, int createdByUserID)
        {
            int id = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Tests
                             VALUES (@TestAppointmentID, @IsPassed, @Notes, @CreatedByUserID);
                                
                             UPDATE TestAppointments
                             SET IsLocked = 1
                             WHERE TestAppointmentID = @TestAppointmentID;

                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@IsPassed", isPassed);
            if (string.IsNullOrWhiteSpace(notes))
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", notes);
            }
            if (createdByUserID > 0)
            {
                command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return id;
        }
        public static bool ExistsByAppointmentID(int testAppointmentID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Tests
                             WHERE TestAppointmentID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", testAppointmentID);

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
        public static byte GetPassedTestsCountByLocalApplicationID(int id)
        {
            byte passedTestsCount = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*)
                             FROM Tests
                             INNER JOIN TestAppointments
                             ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             WHERE TestAppointments.LocalDrivingLicenseApplicationID = @ID
                             AND TestResult = 1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    passedTestsCount = Convert.ToByte(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return passedTestsCount;
        }
        public static byte GetTrialsCountByApplicationAndTestType(int localApplicationID, int testTypeID)
        {
            byte testTrialsCount = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*)
                             FROM Tests
                             INNER JOIN TestAppointments
                             ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             WHERE TestTypeID = @TestTypeID
                             AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    testTrialsCount = Convert.ToByte(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return testTrialsCount;
        }
        public static bool UpdateNotes(int testID, string notes)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE Tests
                             SET Notes = @Notes
                             WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", testID);
            if (string.IsNullOrWhiteSpace(notes))
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", notes);
            }

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
    }
}