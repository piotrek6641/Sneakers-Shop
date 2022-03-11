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
        public bool Specialoffers { get; set; }
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
            mCustomerid = 2;
            mDateAdded = Convert.ToDateTime("2-10-2022");
           
            return true;
        }

        public bool Find(string customer_email)
        {
            mCustomer_email = "norb@gmail.com";
            mAddress = "Leicester le27df jarrom street 44";
            mPhone = "07332986400";
            return true;
        }
       

    }
}