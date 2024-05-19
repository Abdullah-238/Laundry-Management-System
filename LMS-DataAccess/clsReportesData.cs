using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DataAccess
{
    public class clsReportesData
    {

        public static DataTable GetReportesByDate(short year, short month , short day)
        {
            DataTable dtReportesByDate = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from fn_GetOrdersDetiles (@year , @month , @day)";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("year", year);
            Command.Parameters.AddWithValue("month", month);
            Command.Parameters.AddWithValue("day", day);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtReportesByDate.Load(reader);
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
            return dtReportesByDate;
        }

        public static DataTable GetAllTotalAndPaid()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"exec SP_TotalPrice";

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
