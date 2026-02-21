using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class ApplicationDAL
    {
        public static DataTable GetAll()
        {
            DataTable applications = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Applications;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                applications.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return applications;
        }
        public static bool GetByID(int id, ref int personID, ref DateTime date, ref int typeID, ref byte status, ref DateTime lastStatusDate, ref Decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Applications
                             WHERE ApplicationID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personID = (int)reader["ApplicantPersonID"];
                    date = (DateTime)reader["ApplicationDate"];
                    typeID = (int)reader["ApplicationTypeID"];
                    status = (byte)reader["ApplicationStatus"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    paidFees = (Decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];

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
        public static int Add(int personID, DateTime date, int typeID, byte status, DateTime lastStatusDate, Decimal paidFees, int createdByUserID)
        {
            int applicationID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Applications
                             VALUES (@PersonID, @Date, @TypeID, @Status, @LastStatusDate, @PaidFees, @CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@TypeID", typeID);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    applicationID = Convert.ToInt32(result);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return applicationID;
        }
        public static bool Delete(int id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"DELETE FROM Applications
                             WHERE ApplicationID = @ID;";

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
        public static bool ExistsByID(int id)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Applications
                             WHERE ApplicationID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

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
        public static bool ExistsByPersonID(int id)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM Applications
                             WHERE ApplicantPersonID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

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
        public static bool UpdateStatus(int id, byte status)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE Applications
                             SET ApplicationStatus = @Status, LastStatusDate = @LastStatusDate
                             WHERE ApplicationID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

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
        public static bool HasActiveApplicationByTypeAndClass(int personID, int typeID, int licenseClassID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                            FROM Applications
                            INNER JOIN LocalDrivingLicenseApplications
                            ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @PersonID
                            AND ApplicationStatus = 1
                            AND ApplicationTypeID = @TypeID
                            AND LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("PersonID", personID);
            command.Parameters.AddWithValue("@TypeID", typeID);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                connection.Open();

                isExist = command.ExecuteScalar() != null;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
    }
}