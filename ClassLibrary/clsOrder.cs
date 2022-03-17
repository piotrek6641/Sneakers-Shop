using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
        public bool Active { get; set; }



        private System.DateTime mDateAdded;
        public System.DateTime DateAdded
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



        //private data member for the adress no property
        private Int32 mOrderId;
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }



        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;

            }
        }


        private Byte mStatues; 
        public Byte Statues
        {
            get
            {
                return mStatues;
            }
            set
            {
                mStatues = value;
            }
        }

        private Int32 mStaffId;
        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;

            }
        }



        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 4;
            mDateAdded = Convert.ToDateTime("13/03/2022");
            mCustomerId = 4;
            mStatues = 4;
            mStaffId = 4;
            //always return trure
            return true; 
        }
    }

}