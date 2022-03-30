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



        public bool Find(int Customerid)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customerid", Customerid);
            DB.Execute("sproc_tblCustomer_FilterByCustomerid");
            if (DB.Count == 1)
            {
                mCustomerid = Convert.ToInt32(DB.DataTable.Rows[0]["Customerid"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mCustomer_email = Convert.ToString(DB.DataTable.Rows[0]["Customer_email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mSpecialoffers = Convert.ToBoolean(DB.DataTable.Rows[0]["Specialoffers"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);


                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid( string Customer_email, string Phone, string DateAdded, string Address)
        {
            String Error = "";
            DateTime DateTemp;
            Int32 IntTemp;

            if (Customer_email.Length == 0)
            {
                Error = Error + "The Customer_email may not be blank : ";
            }

            if (Customer_email.Length > 50)
            {
                Error = Error + "The Customer_email must be less than 50 characters : ";
            }
            if (Address.Length == 0)
            {
                Error = Error + "The Address may not be blank : ";
            }

            if (Address.Length > 50)
            {
                Error = Error + "The Phone must be less than 50 characters : ";
            }
            if (Phone.Length == 0)
            {
                Error = Error + "The Phone may not be blank : ";
            }

            if (Phone.Length > 15)
            {
                Error = Error + "The Phone must be less than 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid date : ";
            }
            return Error;
        }
    }
}

    