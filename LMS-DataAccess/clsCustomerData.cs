using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsCustomerData
    {

        public static int AddNew( int PersonID)
        {
            int CustomerID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Customers
                           (PersonID)
                           VALUES
                           (@PersonID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoulmnInserted))
                {
                    CustomerID = CoulmnInserted;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return CustomerID;
        }

        public static bool Update(int CustomerID,int PersonID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Customers
                               SET PersonID = @PersonID
                             WHERE CustomerID = @CustomerID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("PersonID", PersonID);
            Command.Parameters.AddWithValue("CustomerID", CustomerID);

            try
            {
                Connection.Open();

                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return (RowAffected > 0);
        }

        public static bool Delete(int CustomerID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Customers
                                 WHERE CustomerID = @CustomerID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("CustomerID", CustomerID);

            try
            {
                Connection.Open();

                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return (RowAffected > 0);
        }

        public static bool Find(int CustomerID,ref int PersonID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Customers WHERE CustomerID = @CustomerID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("CustomerID", CustomerID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;

        }


    }
}
