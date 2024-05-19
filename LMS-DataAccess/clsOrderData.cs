using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsOrderData
    {

        public static int AddNew( decimal OrderPrice , DateTime OrderDate ,
            byte OrderStatus ,
            string Note , int UserID , int CustomerID , int LuandryID , decimal CustomerPaid , byte WashingTime)
        {
            int OrderID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Orders
                           (OrderPrice ,OrderDate , OrderStatus
                           ,Note , UserID ,CustomerID , LuandryID,CustomerPaid,WashingTime)
                           VALUES
                           (@OrderPrice,@OrderDate,@OrderStatus,
                            @Note,@UserID,@CustomerID,@LuandryID,@CustomerPaid,@WashingTime)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("OrderPrice", OrderPrice);
            Command.Parameters.AddWithValue("OrderDate", OrderDate);
            Command.Parameters.AddWithValue("OrderStatus", OrderStatus);
            Command.Parameters.AddWithValue("Note", Note);
            Command.Parameters.AddWithValue("UserID", UserID);
            Command.Parameters.AddWithValue("CustomerID", CustomerID);
            Command.Parameters.AddWithValue("LuandryID", LuandryID);
            Command.Parameters.AddWithValue("WashingTime", WashingTime);
            Command.Parameters.AddWithValue("CustomerPaid", CustomerPaid);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoulmnInserted))
                {
                    OrderID = CoulmnInserted;
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
            return OrderID;
        }

        public static bool Update(int OrderID , decimal OrderPrice, DateTime OrderDate,
            byte OrderStatus,
            string Note, int UserID, int CustomerID, int LuandryID, decimal CustomerPaid,byte WashingTime)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Orders
                               SET OrderPrice = @OrderPrice
                                  , OrderDate = @OrderDate 
                                  , OrderStatus = @OrderStatus 
                                  ,Note =@Note
                                  , UserID = @UserID 
                                  ,CustomerID = @CustomerID
                                  , LuandryID = @LuandryID 
                                  , CustomerPaid = @CustomerPaid
                                  , WashingTime = @WashingTime
                             WHERE OrderID = @OrderID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("OrderID", OrderID);
            Command.Parameters.AddWithValue("OrderPrice", OrderPrice);
            Command.Parameters.AddWithValue("OrderDate", OrderDate);
            Command.Parameters.AddWithValue("OrderStatus", OrderStatus);
            Command.Parameters.AddWithValue("Note", Note);
            Command.Parameters.AddWithValue("UserID", UserID);
            Command.Parameters.AddWithValue("CustomerID", CustomerID);
            Command.Parameters.AddWithValue("LuandryID", LuandryID);
            Command.Parameters.AddWithValue("CustomerPaid", CustomerPaid);
            Command.Parameters.AddWithValue("WashingTime", WashingTime);


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

        public static bool Delete(int OrderID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Orders
                                 WHERE OrderID = @OrderID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("OrderID", OrderID);

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

        public static bool Find(int OrderID,  ref decimal OrderPrice, 
            ref DateTime OrderDate,
           ref byte OrderStatus,
            ref string Note, ref int UserID, ref int CustomerID,ref int LuandryID,
            ref decimal CustomerPaid,ref byte WashingTime)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Orders WHERE OrderID = @OrderID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("OrderID", OrderID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    OrderPrice = (decimal)reader["OrderPrice"];
                    OrderDate = (DateTime)reader["OrderDate"];
                    OrderStatus = (byte)reader["OrderStatus"];
                    if (reader["Note"] != null)
                        Note = (string)reader["Note"];
                    else
                        Note = "";
                    UserID = (int)reader["UserID"];
                    CustomerID = (int)reader["CustomerID"];
                    LuandryID = (int)reader["LuandryID"];
                    CustomerPaid = (decimal)reader["CustomerPaid"];
                   

                    if (reader["WashingTime"] != null)
                        WashingTime = (byte)reader["WashingTime"];
                    else
                        WashingTime = 0;
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
