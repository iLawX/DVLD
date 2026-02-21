using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public static class QuestionChoiceDAL
    {
        public static DataTable GetAllByQuestionID(int questionID)
        {
            DataTable questionChoices = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM QuestionChoices
                             WHERE QuestionID = @QuestionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@QuestionID", questionID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                questionChoices.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return questionChoices;
        }
        public static bool GetByID(int id, ref int questionID, ref string text, ref int displayOrder, ref DateTime createdAt, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM QuestionChoices
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    questionID = (int)reader["QuestionID"];
                    text = (string)reader["Text"];
                    displayOrder = (int)reader["DisplayOrder"];
                    createdAt = (DateTime)reader["CreatedAt"];
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
        public static int Add(int questionID, string text, int displayOrder, DateTime createdAt, int createdByUserID)
        {
            int id = -1;

            SqlConnection connection = new SqlConnection( DataAccessSettings.connectionString);

            string query = @"INSERT INTO QuestionChoices
                             VALUES (@QuestionID, @Text, @DisplayOrder, @CreatedAt, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@QuestionID", questionID);
            command.Parameters.AddWithValue("@Text", text);
            command.Parameters.AddWithValue("@DisplayOrder", displayOrder);
            command.Parameters.AddWithValue("@CreatedAt", createdAt);
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
        public static bool Update(int id, string text, int displayOrder)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE QuestionChoices
                             SET Text = @Text, DisplayOrder = @DisplayOrder
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Text", text);
            command.Parameters.AddWithValue("@DisplayOrder", displayOrder);

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

            string query = @"DELETE FROM QuestionChoices
                             WHERE ID = @ID;";

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
        public static bool DeleteChoicesByQuestionID(int questionID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE Questions
                             SET CorrectChoiceID = @CorrectChoiceID
                             WHERE QuestionID = @QuestionID;

                             DELETE FROM QuestionChoices
                             WHERE QuestionID = @QuestionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@QuestionID", questionID);
            command.Parameters.AddWithValue("@CorrectChoiceID", DBNull.Value);

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