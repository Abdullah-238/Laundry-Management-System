using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsLaundryData
    {

        public static int AddNew(string Name, string Address ,
            string Phone  , string ImagePath)
        {
            int LaundryID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Laundry
                           (Name
                           ,Address
                           ,Phone 
                           , ImagePath)
                           VALUES
                           (@Name,@Address , @Phone , @ImagePath)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("Name", Name);
            Command.Parameters.AddWithValue("Address", Address);
            Command.Parameters.AddWithValue("Phone", Phone);
            Command.Parameters.AddWithValue("ImagePath", ImagePath);


            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoulmnInserted))
                {
                    LaundryID = CoulmnInserted;
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
            return LaundryID;
        }

        public static bool Update(int LuandryID, string Name, string Address,
            string Phone, string ImagePath)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Laundry
                               SET Name = @Name
                                  ,Address = @Address
                                  ,Phone = @Phone
                                  ,ImagePath = @ImagePath
                             WHERE LuandryID = @LuandryID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("Name", Name);
            Command.Parameters.AddWithValue("Address", Address);
            Command.Parameters.AddWithValue("Phone", Phone);
            Command.Parameters.AddWithValue("ImagePath", ImagePath);
            Command.Parameters.AddWithValue("LuandryID", LuandryID);

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

        public static bool Delete(int LuandryID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Laundry
                                 WHERE LuandryID = @LuandryID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("LuandryID", LuandryID);

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

        public static bool Find(int LuandryID, ref string Name,ref string Address,ref string Phone, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Laundry WHERE LuandryID = @LuandryID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("LuandryID", LuandryID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["Name"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["ImagePath"] == null)
                        ImagePath = "";
                    else 
                    ImagePath = (string)reader["ImagePath"];
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

        public static bool FindByName(string Name, ref int LuandryID,   ref string Address, ref string Phone, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Laundry WHERE Name = @Name";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("Name", Name);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    LuandryID = (int)reader["LuandryID"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["ImagePath"] == null)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];
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

        public static DataTable GetAllLaundries(int LuandryID)
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from laundry where LuandryID = @LuandryID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("LuandryID", LuandryID);


            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
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
            return dtUsers;
        }

        public static DataTable GetAllLaundries()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from laundry ";

            SqlCommand Command = new SqlCommand(query, Connection);


            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
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
            return dtUsers;
        }

    }
}
