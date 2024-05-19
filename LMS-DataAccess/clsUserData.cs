using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsUserData
    {

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"exec  SP_GetAllUsers";

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
        public static int AddNew(string UserName, string Password, 
            bool IsActive , int PersonID , int  Permissions)
        {
            int UserID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"exec SP_AddNewUser
                            @UserName 	 = @userName ,	
                            @Password 	 = @password ,	
                            @IsActive 	 = @isActive ,	
                            @PersonID 	 = @personID ,	
                            @Permissions = @permissions";
            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("userName", UserName);
            Command.Parameters.AddWithValue("password", Password);
            Command.Parameters.AddWithValue("isActive", IsActive);
            Command.Parameters.AddWithValue("personID", PersonID);
            Command.Parameters.AddWithValue("permissions", Permissions);


            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoulmnInserted))
                {
                    UserID = CoulmnInserted;
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
            return UserID;
        }

        public static bool Update(int UserID , string UserName, string Password,
            bool IsActive, int PersonID, int Permissions)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users
                               SET UserName = @UserName
                                  ,Password = @Password
                                  ,IsActive = @IsActive
                                  ,PersonID = @PersonID
                                  ,Permissions =@Permissions
                             WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("PersonID", PersonID);
            Command.Parameters.AddWithValue("UserName", UserName);
            Command.Parameters.AddWithValue("Password", Password);
            Command.Parameters.AddWithValue("IsActive", IsActive);
            Command.Parameters.AddWithValue("UserID", UserID);
            Command.Parameters.AddWithValue("Permissions", Permissions);


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

        public static bool Delete(int UserID)
        {
            int RowAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Users WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("UserID", UserID);

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

        public static bool Find(int UserID,ref string UserName,ref
            string Password,ref bool IsActive,ref int PersonID,ref int Permissions)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users WHERE UserID  = @UserID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("UserID", UserID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    PersonID = (int)reader["PersonID"];

                    if (reader["Permissions"] != null)
                    Permissions = (int)reader["Permissions"];
                    else
                    Permissions = 0;

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

        public static bool FindByUserName(string UserName , ref int UserID, ref
          string Password, ref bool IsActive, ref int PersonID , ref int Permissions)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users WHERE UserName  = @UserName";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("UserName", UserName);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    PersonID = (int)reader["PersonID"];
                    if (reader["Permissions"] != null)
                        Permissions = (int)reader["Permissions"];
                    else
                        Permissions = 0;
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

        public static bool FindByUserNameAndPassword(string UserName, string Password , ref int UserID
         , ref bool IsActive, ref int PersonID,ref int Permissions)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users WHERE UserName  = @UserName and Password = @Password";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("UserName", UserName);
            Command.Parameters.AddWithValue("Password", Password);


            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    IsActive = (bool)reader["IsActive"];
                    PersonID = (int)reader["PersonID"];
                    if (reader["Permissions"] != null)
                        Permissions = (int)reader["Permissions"];
                    else
                        Permissions = 0;
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

        public static bool IsUserFoundByUserNameAndPassword(string UserName, string Password)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users
                             WHERE UserName = @UserName and Password = @Password";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("UserName", UserName);
            Command.Parameters.AddWithValue("Password", Password);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;
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

        public static bool IsUserFoundByUserName(string UserName)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users
                             WHERE UserName = @UserName";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("UserName", UserName);
          
            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;
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
