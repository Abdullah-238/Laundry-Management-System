using LMS_DataAccess;
using System.Data;

namespace LMS_BussinessLogic
{
    public class clsLaundry
    {
        enum enMode { AddNewLaundry, UpdateLaundry };

        public int LaundryID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string ImagePath { get; set; }


        enMode _Mode = enMode.AddNewLaundry;

        public clsLaundry()
        {
            this.ImagePath = "";
            this.Name = "";
            this.Address = "";
            this.Phone = "";
            this.LaundryID = -1;

            _Mode = enMode.AddNewLaundry;
        }

        clsLaundry(int laundryID, string Name, string address, string phone, string imagePath)
        {
            this.LaundryID = laundryID;
            this.Name = Name;
            this.Address = address;
            this.Phone = phone;
            this.ImagePath = imagePath;

            _Mode = enMode.UpdateLaundry;
        }

        public static clsLaundry Find(int laundryID)
        {
            string imagePath = "";
            string name = "";
            string address = "";
            string phone = "";

            bool isFound = clsLaundryData.Find(laundryID, ref name, ref address, ref phone, ref imagePath);

            if (isFound)
                return new clsLaundry(laundryID,  name, address, phone,  imagePath);
            else
                return null;
        }

        public static clsLaundry Find(string name)
        {
            string imagePath = "";
            int laundryID = -1;
            string address = "";
            string phone = "";

            bool isFound = clsLaundryData.FindByName(name, ref laundryID, ref address, ref phone, ref imagePath);

            if (isFound)
                return new clsLaundry(laundryID, name, address, phone, imagePath);
            else
                return null;
        }

        bool AddNewLaundry()
        {
            this.LaundryID = clsLaundryData.AddNew(Name, Address, Phone, ImagePath);

            return LaundryID != -1;
        }

        bool UpdateLaundry()
        {
            return clsLaundryData.Update(LaundryID, Name, Address, Phone, ImagePath);
        }

        public static bool DeleteLaundry(int laundryID)
        {
            return clsLaundryData.Delete(laundryID);
        }

        public static DataTable GetAllLuandry(int LuandryID)
        {
            return clsLaundryData.GetAllLaundries(LuandryID);
        }
        public static DataTable GetAllLuandry()
        {
            return clsLaundryData.GetAllLaundries();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNewLaundry:
                    {
                        if (AddNewLaundry())
                        {
                            _Mode = enMode.UpdateLaundry;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateLaundry:
                    return UpdateLaundry();
            }

            return false;
        }


    }
}
