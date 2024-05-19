using LMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BussinessLogic
{
    public class clsCustomers : clsPersons
    {

        enum enMode { AddNewCustomer, UpdateCustomer };

        public int CustomerID { get; set; }

        enMode _Mode = enMode.AddNewCustomer;

        public clsCustomers()
        {
            this.CustomerID = -1;

            _Mode = enMode.AddNewCustomer;
        }

        clsCustomers(int customerID, int personID , string firstName , string lastName , string phone)
        {
            this.CustomerID = customerID;
            this.PersonID = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;


            _Mode = enMode.UpdateCustomer;
        }

        public static clsCustomers Find(int customerID)
        {
            int personID = -1;

            bool isFound = clsCustomerData.Find(customerID, ref personID);

            if (isFound)
            {
                clsPersons Person = clsPersons.Find(personID);

                return new clsCustomers(customerID, personID,
                    Person.FirstName, Person.LastName, Person.Phone);
            }
            else
                return null;
        }

        bool AddNewCustomer()
        {
            this.CustomerID = clsCustomerData.AddNew(PersonID);

            return CustomerID != -1;
        }

        bool UpdateCustomer()
        {
            return clsCustomerData.Update(CustomerID, PersonID);
        }

        public bool DeleteCustomer(int customerID)
        {
            return clsCustomerData.Delete(customerID);
        }

        public bool Save()
        {
            base.Mode = (clsPersons.enMode)_Mode;
            if (!base.Save())
                return false;

            switch (_Mode)
            {
                case enMode.AddNewCustomer:
                    {
                        if (AddNewCustomer())
                        {
                            _Mode = enMode.UpdateCustomer;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateCustomer:
                    return UpdateCustomer();
            }

            return false;
        }



    }
}
