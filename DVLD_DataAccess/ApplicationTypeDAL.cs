using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class ApplicationTypeDAL
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable applicationTypes = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM ApplicationTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                applicationTypes.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return applicationTypes;
        }
        public static bool GetApplicationTypeByID(int id, ref string title, ref decimal fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM ApplicationTypes
                             WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    title = (string)reader["ApplicationTypeTitle"];
                    fees = (decimal)reader["ApplicationFees"];

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
        public static bool Update(int id, string title, decimal fees)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees
                             WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", id);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", title);
            command.Parameters.AddWithValue("@ApplicationFees", fees);

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
        public static decimal GetFeesByID(int id)
        {
            decimal fees = 0m;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT ApplicationFees
                             From ApplicationTypes
                             WHERE ApplicationTypeID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

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
        public static string GetTitleByID(int id)
        {
            string title = "";

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT ApplicationTypeTitle
                             From ApplicationTypes
                             WHERE ApplicationTypeID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    title = result.ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return title;
        }
    }
}
