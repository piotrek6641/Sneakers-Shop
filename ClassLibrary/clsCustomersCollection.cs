using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsCustomersCollection
    {
        List<clsCustomers> mCustomerList = new List<clsCustomers>();
        clsCustomers mThisCustomer = new clsCustomers();
        


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

   

        

        public clsCustomers ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }
            public clsCustomersCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");

            RecordCount = DB.Count;
            

            while (Index < RecordCount)
            {
                clsCustomers AnCustomers = new clsCustomers();


                AnCustomers.Customerid = Convert.ToInt32(DB.DataTable.Rows[Index]["Customerid"]);
                AnCustomers.Customer_email = Convert.ToString(DB.DataTable.Rows[Index]["Customer_email"]);
                AnCustomers.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCustomers.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomers.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnCustomers.Specialoffers = Convert.ToBoolean(DB.DataTable.Rows[Index]["Specialoffers"]);

                mCustomerList.Add(AnCustomers);

                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customer_email", mThisCustomer.Customer_email);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Specialoffers", mThisCustomer.Specialoffers);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customer_email", mThisCustomer.Customer_email);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Specialoffers", mThisCustomer.Specialoffers);

            DB.Execute("sproc_tblCustomer_Update");
        }
    }
    }




        