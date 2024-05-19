using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public  class clsOrderItems
    {
        enum enMode { AddNewOrderItems, UpdateOrderItems };

        public int NumberOfItems { get; set; }
        public int OrderID { get; set; }

        public int ItemID { get; set; }

        enMode _Mode = enMode.AddNewOrderItems;

        public clsOrderItems()
        {
            this.NumberOfItems = -1;
            this.ItemID = -1;
            this.OrderID = -1;

            _Mode = enMode.AddNewOrderItems;
        }

        clsOrderItems( int OrderID , int ItemID, int NumberOfItems)
        {
            this.NumberOfItems = NumberOfItems;
            this.OrderID = OrderID;
            this.ItemID = ItemID;
          
            _Mode = enMode.UpdateOrderItems;
        }

        bool AddNewUser()
        {
            int RowAffected = 0;

            RowAffected = clsOrderItemsData.AddNew(OrderID,ItemID , NumberOfItems);

            return RowAffected != -1;
        }
      
        public static bool DeleteUser(int orderId , int ItemId)
        {
            return clsOrderItemsData.Delete(orderId, ItemId);
        }

        bool UpdateOrderItems()
        {
            return clsOrderItemsData.Update(OrderID,ItemID, NumberOfItems);
        }

        public static DataTable GetAllOrderItems(int orderId)
        {
            return clsOrderItemsData.GetAllOrderItems(orderId);
        }
        public static DataTable GetBillInfo(int orderId)
        {
            return clsOrderItemsData.GetBillInfo(orderId);
        }
        public bool Save()
        {
          
            switch (_Mode)
            {
                case enMode.AddNewOrderItems:
                    {
                        return AddNewUser();
                      
                    }
                case enMode.UpdateOrderItems:
                    return UpdateOrderItems();
            }

            return false;
        }

    }
}
