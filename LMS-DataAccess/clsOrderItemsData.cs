using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public class clsOrderItemsData
    {
        public static DataTable GetBillInfo(int OrderID)
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Items.ItemName , Items.ItemPrice ,
                             NumbersOfItems  as 'Qty'  , NumbersOfItems * Items.ItemPrice as Total
                             from OrderItems 
                             join Items on OrderItems.ItemID = Items.ItemID
                             and OrderItems.OrderID = @OrderID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("OrderID", OrderID);


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

        public static DataTable GetAllOrderItems(int OrderID)
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from orderItems where OrderID = @OrderID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("OrderID", OrderID);


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

        public static int AddNew(int OrderID, int ItemID , int NumbersOfItems)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO orderItems
                           (OrderID
                           ,ItemID
                           , NumbersOfItems)
                           VALUES
                           (@OrderID
                           ,@ItemID
                           ,@NumbersOfItems)";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("OrderID", OrderID);
            Command.Parameters.AddWithValue("ItemID", ItemID);
            Command.Parameters.AddWithValue("NumbersOfItems", NumbersOfItems);


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
            return RowAffected;
        }

        public static bool Delete(int OrderID, int ItemID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete orderItems
                                 WHERE OrderID = @OrderID and ItemID =@ItemID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("OrderID", OrderID);
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

        public static bool Update(int OrderID, int ItemID
            , int NumbersOfItems)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE orderItems
                               SET  NumbersOfItems = @NumbersOfItems 
                              
                             WHERE OrderID = @OrderID and ItemID = @ItemID";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("OrderID", OrderID);
            Command.Parameters.AddWithValue("ItemID", ItemID);
            Command.Parameters.AddWithValue("NumbersOfItems", NumbersOfItems);

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

    }
}
