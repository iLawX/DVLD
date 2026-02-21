using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class QuestionDAL
    {
        public static DataTable GetAll()
        {
            DataTable questions = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Questions_View;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                questions.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return questions;
        }
        public static DataTable GetRandomQuestions(int writtenTestTypeID)
        {
            DataTable questions = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"WITH RandomQuestions AS
                            (
	                            SELECT TOP (SELECT NumberOfQuestions FROM WrittenTestTypes WHERE ID = @WrittenTestTypeID) Questions.ID AS QuestionID, Questions.Text AS QuestionText, CorrectChoiceID
	                            FROM Questions
	                            WHERE WrittenTestTypeID = @WrittenTestTypeID
                            )

                            SELECT RandomQuestions.QuestionID, RandomQuestions.QuestionText, RandomQuestions.CorrectChoiceID, QuestionChoices.ID AS ChoiceID, QuestionChoices.Text AS ChoiceText, QuestionChoices.DisplayOrder
                            FROM RandomQuestions
                            INNER JOIN QuestionChoices
                            ON RandomQuestions.QuestionID = QuestionChoices.QuestionID
                            ORDER BY NEWID();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@WrittenTestTypeID", writtenTestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                questions.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return questions;
        }
        public static bool GetByID(int id, ref int writtenTestTypeID, ref string text, ref int correctChoiceID, ref DateTime createdAt, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Questions
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    writtenTestTypeID = (int)reader["WrittenTestTypeID"];
                    text = (string)reader["Text"];
                    if (reader["CorrectChoiceID"] != DBNull.Value)
                    {
                        correctChoiceID = (int)reader["CorrectChoiceID"];
                    }
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
        public static int Add(int writtenTestTypeID, string text, DateTime createdAt, int createdByUserID)
        {
            int id = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Questions
                             VALUES (@WrittenTestTypeID, @Text, @CorrectChoiceID, @CreatedAt, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@WrittenTestTypeID", writtenTestTypeID);
            command.Parameters.AddWithValue("@Text", text);
            command.Parameters.AddWithValue("@CorrectChoiceID", DBNull.Value);
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
        public static bool Update(int id, int writtenTestTypeID, string text, int correctChoiceID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE Questions
                             SET WrittenTestTypeID = @WrittenTestTypeID, Text = @Text, CorrectChoiceID = @CorrectChoiceID
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@WrittenTestTypeID", writtenTestTypeID);
            command.Parameters.AddWithValue("@Text", text);
            if (correctChoiceID > 0)
            {
                command.Parameters.AddWithValue("@CorrectChoiceID", correctChoiceID);
            }
            else
            {
                command.Parameters.AddWithValue("@CorrectChoiceID", DBNull.Value);
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
        public static bool Delete(int id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"DELETE FROM Questions
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
        public static int GetQuestionsCountByWrittenTestTypeID(int writtenTestTypeID)
        {
            int questionsCount = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*)
                             FROM Questions
                             WHERE WrittenTestTypeID = @WrittenTestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@WrittenTestTypeID", writtenTestTypeID);

            try
            {
                connection.Open();

                questionsCount = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close(); 
            }

            return questionsCount;
        }
    }
}