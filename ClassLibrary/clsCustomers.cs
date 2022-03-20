using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        private Int32 mCustomerid;
        private String mCustomer_email;
        private String mAddress;
        private String mPhone;
        private DateTime mDateAdded;
        private Boolean mSpecialoffers;
        public bool Specialoffers
        {
            get
            {
                return mSpecialoffers;
            }
            set
            {
                mSpecialoffers = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public Int32 Customerid
        {
            get
            {
                return mCustomerid;
            }
            set
            {
                mCustomerid = value;
            }
        }
        public string Customer_email
        {
            get
            {
                return mCustomer_email;
            }
            set
            {
                mCustomer_email = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }



        public bool Find(int customerid)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customerid", Customerid);
            DB.Execute("sproc_tblCustomer_FilterByCustomerid");
            if (DB.Count == 1)
            {
                mCustomerid = Convert.ToInt32(DB.DataTable.Rows[0]["Customerid"]);
               
                return true;
            }
            else 
            {
                return false;
            }

           
            
        }

        public bool Find(string phone)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customerid", Customerid);
            DB.Execute("sproc_tblCustomer_FilterByCustomerid");
            if (DB.Count == 1)
            {
                
                mCustomer_email = Convert.ToString(DB.DataTable.Rows[0]["Customer_email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mSpecialoffers = Convert.ToBoolean(DB.DataTable.Rows[0]["Specialoffers"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}