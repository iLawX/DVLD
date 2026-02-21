using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class TestTypeDAL
    {
        public static DataTable GetAll()
        {
            DataTable testTypes = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM TestTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                testTypes.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return testTypes;
        }
        public static bool GetTestTypeByID(int id, ref string title, ref string description, ref decimal fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM TestTypes
                             WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    title = (string)reader["TestTypeTitle"];
                    description = (string)reader["TestTypeDescription"];
                    fees = (decimal)reader["TestTypeFees"];

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
        public static bool Update(int id, string title, string description, decimal fees)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE TestTypes
                             SET TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees
                             WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", id);
            command.Parameters.AddWithValue("@TestTypeTitle", title);
            command.Parameters.AddWithValue("@TestTypeDescription", description);
            command.Parameters.AddWithValue("@TestTypeFees", fees);

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

            string query = @"SELECT TestTypeFees
                             From TestTypes
                             WHERE TestTypeID = @ID;";

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
    }
}
