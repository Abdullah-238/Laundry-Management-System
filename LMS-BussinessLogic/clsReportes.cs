using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public class clsReportes
    {
        public static DataTable GetAllTotalAndPaid()
        {
            return clsReportesData.GetAllTotalAndPaid();
        }

        public static DataTable GetReportesByDate(short Year , short Month , short Day)
        {
            return clsReportesData.GetReportesByDate(Year,Month,Day);
        }



    }
}
