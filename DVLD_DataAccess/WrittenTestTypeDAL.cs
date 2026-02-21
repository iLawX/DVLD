using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class WrittenTestTypeDAL
    {
        public static DataTable GetAll()
        {
            DataTable writtenTestTypes = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM WrittenTestTypes_View;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                writtenTestTypes.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return writtenTestTypes;
        }
        public static bool GetByID(int id, ref int licenseClassID, ref int durationInMinutes, ref int numberOfQuestions, ref decimal passPercentage)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM WrittenTestTypes
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    licenseClassID = (int)reader["LicenseClassID"];
                    durationInMinutes = (int)reader["DurationInMinutes"];
                    numberOfQuestions = (int)reader["NumberOfQuestions"];
                    passPercentage = (decimal)reader["PassPercentage"];

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
        public static bool Update(int id, int durationInMinutes, int numberOfQuestions, decimal passPercentage)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE WrittenTestTypes
                             SET DurationInMinutes = @DurationInMinutes, NumberOfQuestions = @NumberOfQuestions, PassPercentage = @PassPercentage
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@DurationInMinutes", durationInMinutes);
            command.Parameters.AddWithValue("@NumberOfQuestions", numberOfQuestions);
            command.Parameters.AddWithValue("@PassPercentage", passPercentage);

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
