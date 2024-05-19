using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public class clsUsers : clsPersons
    {
        enum enMode { AddNewUser, UpdateUser };

        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public enPermissions Permission { get; set; }


        enMode _Mode = enMode.AddNewUser;

        public enum enPermissions
        {
            eMangeUsers = 1 , eMangeItems = 2 , eMangeLaundry = 4 ,
            eMangeReportes = 8  , eAll = 16
        }

        public clsUsers()
        {
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this.UserID = -1;
            this.Permission = enPermissions.eAll; 
            _Mode = enMode.AddNewUser;
        }

        clsUsers(int personID,int userID ,  string userName, string password,
            bool isActive, int permission ,
            string firstName
            ,string lastName , string phone )
        {
            this.PersonID = personID;
            this.UserID   = userID;
            this.Password = password;
            this.IsActive = isActive;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName; 
            this.Phone = phone;
            this.Permission = (enPermissions)permission;

            _Mode = enMode.UpdateUser;
        }

        public static clsUsers Find(int UserID)
        {
            int personID = -1;
            string userName = "";
            string password = "";
            bool isActive = false;
            int permission = 0; 

            bool isFound = clsUserData.Find(UserID, ref userName, ref password,
                ref isActive,ref personID,ref permission);

            if (isFound)
            {
                clsPersons Person = clsPersons.Find(personID);

                return new clsUsers(personID, UserID, userName, password, isActive, permission,
                    Person.FirstName,Person.LastName,Person.Phone);
            }
            else
                return null;
        }

        public static clsUsers FindByUserName(string userName)
        {
            int personID = -1;
            int userID  = -1;
            string password = "";
            bool isActive = false;
            int permission = 0;


            bool isFound = clsUserData.FindByUserName(userName, ref userID, ref password,
                ref isActive, ref personID,ref permission);

            if (isFound)
            {
                clsPersons Person = clsPersons.Find(personID);

                return new clsUsers(personID, userID, userName, password, isActive, permission,
                    Person.FirstName, Person.LastName, Person.Phone);
            }
            else
                return null;
        }

        public static clsUsers FindByUserNameAndPassword(string userName, string password)
        {
            int personID = -1;
            int userID = -1;
            bool isActive = false;
            int permission = 0; 

            bool isFound = clsUserData.FindByUserNameAndPassword(userName, password,
                ref userID,  ref isActive, ref personID,ref permission);

            if (isFound)
            {
                clsPersons Person = clsPersons.Find(personID);

                return new clsUsers(personID, userID, userName, password, isActive, permission,
                    Person.FirstName, Person.LastName, Person.Phone);
            }
            else
                return null;
        }

        bool AddNewUser()
        {
            this.UserID = clsUserData.AddNew( UserName,  Password,  IsActive,  PersonID,(int)Permission);

            return PersonID != -1;
        }

        bool UpdateUser()
        {
            return clsUserData.Update(UserID,UserName, Password, IsActive, PersonID,(int)Permission);
        }

        public static bool DeleteUser(int userID)
        {
            return clsUserData.Delete(userID);
        }

        public static bool IsUserNameFound(string  UserName)
        {
            return clsUserData.IsUserFoundByUserName(UserName);
        }

        public static bool IsUserFoundByUserNameAndPassword(string UserName,string Password)
        {
            return clsUserData.IsUserFoundByUserNameAndPassword(UserName, Password);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool Save()
        {
            base.Mode = (clsPersons.enMode)_Mode;
            if (!base.Save())
                return false;

            switch (_Mode)
            {
                case enMode.AddNewUser:
                    {
                        if (AddNewUser())
                        {
                            _Mode = enMode.UpdateUser;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateUser:
                    return UpdateUser();
            }

            return false;
        }

        public bool CheckAccessPermissions(enPermissions permissions)
        {
            if (this.Permission == enPermissions.eAll)
                return true;

            if ((permissions & this.Permission) == permissions)
                return true; 

            return false;
        }

    }
}
