using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{

    public class clsItem
    {
        enum enMode { AddNewItem, UpdateItem };

        public int ItemID { get; set; }

        public string ItemName { get; set; }
        public string ImagePath { get; set; }

        public decimal ItemPrice { get; set; }

        enMode _Mode = enMode.AddNewItem;

        public clsItem()
        {
            this.ItemID = -1;
            this.ItemName = "";
            this.ItemPrice = -1;
            this.ImagePath = "";

            _Mode = enMode.AddNewItem;
        }

        clsItem(int itemID, string itemName, decimal itemPrice , string ImagePath)
        {
            this.ItemID = itemID;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.ImagePath = ImagePath; 

            _Mode = enMode.UpdateItem;
        }

        public static clsItem Find(int itemID)
        {
            string itemName = "";
            decimal itemPrice = -1;
            string imagePath = "";

            bool isFound = clsItemData.Find(itemID, ref itemName, ref itemPrice, ref imagePath);

            if (isFound)
                return new clsItem(itemID,  itemName, itemPrice, imagePath);
            else
                return null;
        }

        bool AddNewItem()
        {
            this.ItemID = clsItemData.AddNew(ItemName,ItemPrice, ImagePath);

            return ItemID != -1;
        }

        bool UpdateItem()
        {
            return clsItemData.Update(ItemID, ItemName, ItemPrice, ImagePath);
        }

        public static bool DeleteItem(int itemID)
        {
            return clsItemData.Delete(itemID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNewItem:
                    {
                        if (AddNewItem())
                        {
                            _Mode = enMode.UpdateItem;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateItem:
                    return UpdateItem();
            }

            return false;
        }

        public static DataTable GetAllItems()
        {
            return clsItemData.GetAllItems();
        }
    }
}
