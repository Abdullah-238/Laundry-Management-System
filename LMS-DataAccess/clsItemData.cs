using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsItemData
    {

        public static int AddNew(string ItemName, decimal ItemPrice,string ImagePath)
        {
            int ItemID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Items
                           (ItemName
                           ,ItemPrice,ImagePath)
                           VALUES
                           (@ItemName,@ItemPrice , @ImagePath)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("ItemName", ItemName);
            Command.Parameters.AddWithValue("ItemPrice", ItemPrice);
            Command.Parameters.AddWithValue("ImagePath", ImagePath);


            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoulmnInserted))
                {
                    ItemID = CoulmnInserted;
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
            return ItemID;
        }

        public static bool Update(int ItemID , string ItemName, decimal ItemPrice, string ImagePath)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Items
                               SET ItemName = @ItemName
                                  ,ItemPrice = @ItemPrice 
                                  , ImagePath =@ImagePath
                             WHERE ItemID = @ItemID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("ItemID", ItemID);
            Command.Parameters.AddWithValue("ItemName", ItemName);
            Command.Parameters.AddWithValue("ItemPrice", ItemPrice);
            Command.Parameters.AddWithValue("ImagePath", ImagePath);


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

        public static bool Delete(int ItemID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Items
                                 WHERE ItemID = @ItemID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("ItemID", ItemID);

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

        public static bool Find(int ItemID,ref string ItemName,ref decimal ItemPrice,ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Items WHERE ItemID = @ItemID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("ItemID", ItemID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    ItemName = (string)reader["ItemName"];
                    ItemPrice = (decimal)reader["ItemPrice"];
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

        public static DataTable GetAllItems()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from items";

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
