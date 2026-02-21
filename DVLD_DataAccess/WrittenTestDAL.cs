using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class WrittenTestDAL
    {
        public static int Add(int writtenTestTypeID, int testAppointmentID, DateTime startTime, DateTime endTime, int totalQuestions, int correctAnswers, bool passed, DateTime createdAt)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO WrittenTests
                             VALUES (@WrittenTestTypeID, @TestAppointmentID, @StartTime, @EndTime, @TotalQuestions, @CorrectAnswers, @Passed, @CreatedAt);

                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@WrittenTestTypeID", writtenTestTypeID);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@StartTime", startTime);
            command.Parameters.AddWithValue("@EndTime", endTime);
            command.Parameters.AddWithValue("@TotalQuestions", totalQuestions);
            command.Parameters.AddWithValue("@CorrectAnswers", correctAnswers);
            command.Parameters.AddWithValue("@Passed", passed);
            command.Parameters.AddWithValue("@CreatedAt", createdAt);

            try
            {
                connection.Open();

                id = Convert.ToInt32(command.ExecuteScalar());
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
