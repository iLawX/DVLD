using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public static class InternationalLicenseDAL
    {
        public static DataTable GetAll()
        {
            DataTable internationalLicesnes = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM InternationalLicenses_View
                             ORDER BY IsActive, ExpirationDate DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                internationalLicesnes.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return internationalLicesnes;
        }
        public static DataTable GetAllByDriverID(int driverID)
        {
            DataTable internationalLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT InternationalLicenseID AS ID, ApplicationID, IssuedUsingLocalLicenseID AS LocalLicenseID, IssueDate, ExpirationDate, IsActive
                             FROM InternationalLicenses
                             WHERE DriverID = @DriverID
                             ORDER BY IsActive DESC, IssueDate DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", driverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                internationalLicenses.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return internationalLicenses;
        }
        public static bool GetByID(int id, ref int applicationID, ref int driverID, ref int localDrivingLicenseID, ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM InternationalLicenses
                             WHERE InternationalLicenseID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    localDrivingLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = (bool)reader["IsActive"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    isFound = true;
                }

                reader.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetByDriverID(ref int id, ref int applicationID, int driverID, ref int localDrivingLicenseID, ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM InternationalLicenses
                             WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", driverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["InternationalLicenseID"];
                    applicationID = (int)reader["ApplicationID"];
                    localDrivingLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = (bool)reader["IsActive"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    isFound = true;
                }

                reader.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool ExistsByLocalLicenseID(int localDrivingLicenseID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM InternationalLicenses
                             WHERE IssuedUsingLocalLicenseID = @LocalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalLicenseID", localDrivingLicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {

            }
            {
                connection.Close();
            }

            return isExist;
        }
        public static int Add(int applicationID, int driverID, int localDrivingLicenseID, DateTime issueDate, DateTime expirationDate, int createdByUserID)
        {
            int id = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO InternationalLicenses
                             VALUES (@ApplicationID, @DriverID, @LocalDrivingLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseID", localDrivingLicenseID);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@IsActive", true);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

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
    }
}
