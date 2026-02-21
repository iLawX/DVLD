using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class DetainedLicenseDAL
    {
        public static DataTable GetAll()
        {
            DataTable detainedLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM DetainedLicenses_View
                             ORDER BY IsReleased, ID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                detainedLicenses.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return detainedLicenses;
        }
        public static bool GetByID(int detainID, ref int licenseID, ref DateTime detentionDate, ref decimal fineFees, ref int detainedByUserID, ref bool isReleased, ref DateTime releaseDate, ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM DetainedLicenses
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", detainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    licenseID = (int)reader["LicenseID"];
                    detentionDate = (DateTime)reader["DetentionDate"];
                    fineFees = (decimal)reader["FineFees"];
                    detainedByUserID = (int)reader["DetainedByUserID"];
                    isReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        releaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        releasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        releaseApplicationID = (int)reader["ReleasedByApplicationID"];
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
        public static bool GetByLicenseID(ref int detainID, int licenseID, ref DateTime detentionDate, ref decimal fineFees, ref int detainedByUserID, ref bool isReleased, ref DateTime releaseDate, ref int releasedByUserID, ref int releaseApplicationID) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID
                             AND IsReleased = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    detainID = (int)reader["DetainID"];
                    detentionDate = (DateTime)reader["DetentionDate"];
                    fineFees = (decimal)reader["FineFees"];
                    detainedByUserID = (int)reader["DetainedByUserID"];
                    isReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        releaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        releasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        releaseApplicationID = (int)reader["ReleaseApplicationID"];
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
        public static int Add(int licenseID, decimal fineFees, int detainedByUserID)
        {
            int id = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO DetainedLicenses
                             VALUES (@LicenseID, @DetentionDate, @FineFees, @DetainedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                             
                             UPDATE Licenses
                             SET IsActive = 0
                             WHERE LicenseID = @LicenseID;

                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@DetentionDate", DateTime.Now);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@DetainedByUserID", detainedByUserID);
            command.Parameters.AddWithValue("@IsReleased", 0);
            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

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
        public static bool IsLicenseDetained(int licenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT 1
                             FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID
                             AND IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                
                isFound = command.ExecuteScalar() != null;
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
        public static bool ReleaseDetainedLicense(int licenseID, int releasedByUserID, int releaseApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE DetainedLicenses
                             SET IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                             WHERE LicenseID = @LicenseID;

                             UPDATE Licenses
                             SET IsActive = 1
                             WHERE LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID);

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
