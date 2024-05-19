using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsPersonsData
    {
        public static int AddNew(string FirstName , string LastName ,string Phone)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Persons
                           (FirstName
                           ,LastName
                           ,Phone)
                           VALUES
                           (@FirstName,@LastName,@Phone)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("FirstName", FirstName);
            Command.Parameters.AddWithValue("LastName", LastName);
            Command.Parameters.AddWithValue("Phone", Phone);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null &&  int.TryParse(result.ToString(), out int CoulmnInserted))
                {
                    PersonID = CoulmnInserted;
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
            return PersonID; 
        }

        public static bool Update(int PersonID , string FirstName, string LastName, string Phone)
        {
            int RowAffected = -1; 

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Persons
                               SET FirstName = @FirstName
                                  ,LastName = @LastName
                                  ,Phone = @Phone
                             WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("PersonID", PersonID);
            Command.Parameters.AddWithValue("FirstName", FirstName);
            Command.Parameters.AddWithValue("LastName", LastName);
            Command.Parameters.AddWithValue("Phone", Phone);

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

        public static bool Delete(int PersonID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Persons
                                 WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("PersonID", PersonID);
           
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

        public static bool Find(int PersonID, ref string FirstName,ref string LastName,ref string Phone)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from  Persons WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("PersonID", PersonID);

            try
            {
                Connection.Open();

               SqlDataReader reader =  Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    FirstName = (string)reader["FirstName"];

                    if (reader["LastName"] != null)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    Phone = (string)reader["Phone"];
                }
                reader.Close();

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
