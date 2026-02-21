using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class TestAppointmentDAL
    {
        public static DataTable GetAll()
        {
            DataTable testAppointments = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM TestAppointments
                             ORDER BY AppointmentDate DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                testAppointments.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return testAppointments;
        }
        public static DataTable GetAllByApplicationAndTestType(int LocalDrivingLicenseApplicationID, int testTypeID)
        {
            DataTable testAppointments = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT TestAppointmentID AS ID, AppointmentDate AS Date, PaidFees, IsLocked
                             FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             AND TestTypeID = @TestTypeID
                             ORDER BY TestAppointmentID DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                testAppointments.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return testAppointments;
        }
        public static DataTable GetAllWrittenAppointmentByPersonID(int personID)
        {
            DataTable writtenTestAppointments = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT TestAppointmentID AS ID, AppointmentDate, ClassName, TestAppointments.PaidFees FROM TestAppointments
                             INNER JOIN LocalDrivingLicenseApplications
                             ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                             INNER JOIN LicenseClasses
                             ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                             INNER JOIN Applications
                             ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                             WHERE TestTypeID = 2
                             AND IsLocked = 0
                             AND ApplicantPersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                writtenTestAppointments.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close(); 
            }

            return writtenTestAppointments;
        }
        public static bool GetByID(int id, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime date, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM TestAppointments
                             WHERE TestAppointmentID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    testTypeID = (int)reader["TestTypeID"];
                    localDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    date = (DateTime)reader["AppointmentDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isLocked = (bool)reader["IsLocked"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        retakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
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
        public static bool GetLatestTestAppointment(ref int id, int testTypeID, int localDrivingLicenseApplicationID, ref DateTime date, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplication)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT TOP 1 *
                             FROM TestApppointments
                             WHERE TestTypeID = @TestTypeID
                             AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             ORDER BY TestAppointment DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["TestAppointmentID"];
                    date = (DateTime)reader["AppointmentDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isLocked = (bool)reader["IsLocked"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        retakeTestApplication = (int)reader["RetakeTestApplicationID"];
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
        public static int Add(int testTypeID, int localDrivingLicenseApplicationID, DateTime date, decimal paidFees, int createdByUserID, int retakeTestApplicationID)
        {
            int testAppointmentID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO TestAppointments
                             VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @Date, @PaidFees, @CreatedByUserID, 0, @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            if (retakeTestApplicationID > 0)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", retakeTestApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        testAppointmentID = Convert.ToInt32(result);
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }

            return testAppointmentID;
        }
        public static bool Update(int id, DateTime date)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE TestAppointments
                             SET AppointmentDate = @Date
                             WHERE TestAppointmentID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Date", date);

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
        public static bool Delete(int id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"DELETE FROM TestAppointments
                             WHERE TestAppointmentID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

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
        public static bool Lock(int id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE TestAppointments
                             SET IsLocked = 1
                             WHERE TestAppointmentID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

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
