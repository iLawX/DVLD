using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class LicenseClassDAL
    {
        public static DataTable GetAll()
        {
            DataTable licenseClasses = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM LicenseClasses;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                licenseClasses.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return licenseClasses;
        }
        public static bool GetByID(int id, ref string name, ref string description, ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM LicenseClasses
                             WHERE LicenseClassID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    name = (string)reader["ClassName"];
                    description = (string)reader["ClassDescription"];
                    minimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    defaultValidityLength = (byte)reader["DefaultValidityLength"];
                    fees = (decimal)reader["ClassFees"];

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
        public static int GetMinimumAllowedAgeByLicenseClassID(int licenseClassID)
        {
            int minimumAllowedAge = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT MinimumAllowedAge
                             FROM LicenseClasses
                             WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    minimumAllowedAge = Convert.ToInt32(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return minimumAllowedAge;
        }
        public static decimal GetFeesByClassID(int classID)
        {
            decimal fees = 0m;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT ClassFees
                             FROM LicenseClasses
                             WHERE LicenseClassID = @ClassID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassID", classID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    fees = Convert.ToDecimal(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return fees;
        }
    }
}
