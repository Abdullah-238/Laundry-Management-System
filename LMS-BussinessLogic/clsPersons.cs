using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public class clsPersons
    {
        public enum enMode { AddNewPerson , UpdatePerson};

        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

       public enMode Mode = enMode.AddNewPerson;

        public clsPersons()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";

            Mode = enMode.AddNewPerson;
        }

        clsPersons(int personID, string firstName, string lastName, string phone)
        {
            this.PersonID = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;

            Mode = enMode.UpdatePerson;
        }

        public static clsPersons Find(int PersonID)
        {
            string firstName = "";  string lastName = "";  string phone = "";

            bool isFound = clsPersonsData.Find(PersonID, ref firstName, ref lastName, ref phone);

            if (isFound)
                return new clsPersons(PersonID, firstName, lastName, phone);
            else
                return null;
        }

        bool AddNewPerson()
        {
            this.PersonID = clsPersonsData.AddNew(FirstName, LastName, Phone);

            return PersonID != -1; 
        }

        bool UpdatePerson()
        {
            return clsPersonsData.Update(PersonID, FirstName, LastName, Phone);
        }

        public bool DeletePerson(int personID)
        {
            return clsPersonsData.Delete(personID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNewPerson :
                    {
                        if (AddNewPerson())
                        {
                            Mode = enMode.UpdatePerson;
                            return true;
                        }
                       else
                           return false; 
                    }
                 case enMode.UpdatePerson :
                    return UpdatePerson();
            }
            
            return false;
        }


    }

}
