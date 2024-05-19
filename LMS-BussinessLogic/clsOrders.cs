using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public class clsOrders
    {

        enum enMode { AddNewOrder, UpdateOrder };
        public int OrderID { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public enStatus OrderStatus { get; set; }
        public string Note { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int LuandryID { get; set; }
        public decimal CustomerPaid { get; set; }
        public enWashingTime WashingTime { get; set; }


        public enum enStatus
        {
            eNew = 1 , eCompleted , eCancel
        }
        public enum enWashingTime
        {
            eFast = 1, eNormal
        }


        public string WashingString()
        {
            switch(WashingTime)
            {
                case enWashingTime.eNormal:
                    return "Normal";
                case enWashingTime.eFast:
                    return "Fast";
                default:
                    return "Normal";

            }
        }

        public clsPersons Person;


        enMode _Mode = enMode.AddNewOrder;

        public clsOrders()
        {
            this.OrderID = -1;
            this.OrderPrice = 0;
            this.OrderDate = DateTime.Now;
            this.OrderStatus = enStatus.eNew;
            this.Note = "";
            this.UserID = -1;
            this.CustomerID = -1;
            this.LuandryID = -1;
            this.Person = new clsPersons();
            this.CustomerPaid = -1;
            this.WashingTime = enWashingTime.eFast;
            _Mode = enMode.AddNewOrder;
        }

        clsOrders(int orderID, decimal orderPrice,
             DateTime orderDate,
            byte orderStatus,
             string note,  int userID,  int customerID,  int luandryID,decimal CustomerPaid , 
             byte WashingTime)
        {
            this.OrderID = orderID;
            this.OrderPrice = orderPrice;
            this.OrderDate = orderDate;
            this.OrderStatus = (enStatus)orderStatus;
            this.Note = note;
            this.UserID = userID;
            this.CustomerID = customerID;
            this.LuandryID = luandryID;
            this.Person = clsPersons.Find(clsCustomers.Find(customerID).PersonID);
            this.CustomerPaid = CustomerPaid;
            this.WashingTime = (enWashingTime)WashingTime;
            _Mode = enMode.UpdateOrder;
        }

        public static clsOrders Find(int orderID)
        {
              decimal orderPrice = -1;
             DateTime orderDate = DateTime.Now;
            byte orderStatus = 0;
            string note = "";   int userID = -1;  int customerID = -1; 
            int luandryID = -1; decimal customerPaid = -1; byte WashingTime = 0;

            bool isFound = clsOrderData.Find(orderID, ref orderPrice,
             ref orderDate,
            ref orderStatus,
             ref note, ref userID, ref customerID,ref luandryID,ref customerPaid,ref WashingTime);

            if (isFound)
                return new clsOrders( orderID,    orderPrice,
              orderDate,
             orderStatus,
              note,  userID,  customerID,  luandryID, customerPaid, WashingTime);
            else
                return null;
        }

        bool AddNewUser()
        {
            this.OrderID = clsOrderData.AddNew(OrderPrice,OrderDate,(byte)OrderStatus,
                Note,UserID,CustomerID,LuandryID, CustomerPaid,(byte)WashingTime);

            return OrderID != -1;
        }

        bool UpdateUser()
        {
            return clsOrderData.Update(OrderID, OrderPrice, OrderDate,(byte) OrderStatus,
                Note, UserID, CustomerID, LuandryID, CustomerPaid,(byte)WashingTime);
        }

        public static bool DeleteUser(int OrderID)
        {
            return clsOrderData.Delete(OrderID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNewOrder:
                    {
                        if (AddNewUser())
                        {
                            _Mode = enMode.UpdateOrder;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateOrder:
                    return UpdateUser();
            }

            return false;
        }

        
    }
}
