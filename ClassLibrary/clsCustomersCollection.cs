using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsCustomersCollection
    {
        List<clsCustomers> mCustomerList = new List<clsCustomers>();
        clsCustomers mThisCustomeremail = new clsCustomers();


        public List<clsCustomers> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

   

        public clsCustomers ThisCustomeremail
        {
            get
            {
                return ThisCustomeremail;
            }
            set
            {
                ThisCustomeremail = value;
            }
        }
    }
}



        