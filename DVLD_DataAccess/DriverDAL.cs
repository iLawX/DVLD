using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class DriverDAL
    {
        public static DataTable GetAll()
        {
            DataTable drivers = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Drivers_View;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                drivers.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return drivers;
        }
        public static bool GetByID(int id, ref int personID, ref int createdByUserID, ref DateTime createdAt)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Drivers
                             WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    createdAt = (DateTime)reader["CreatedAt"];

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
        public static bool GetByPersonID(ref int id, int personID, ref int createdByUserID, ref DateTime createdAt)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Drivers
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["DriverID"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    createdAt = (DateTime)reader["CreatedAt"];

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
        public static int Add(int personID, int createdByUserID)
        {
            int driverID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedAt)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedAt);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    driverID = Convert.ToInt32(result);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();

            }
            return driverID;
        }
    }
}