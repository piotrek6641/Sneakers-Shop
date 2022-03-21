using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        public Boolean mActive; 
        public bool Active 
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }



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


        public bool Find (int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderNo", OrderId);
            DB.Execute("sproc_tblOrdr_FilterByOrderNo");
            if (DB.Count == 1) 
            {
                //set the private data members to the test data value
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mStatues = Convert.ToByte(DB.DataTable.Rows[0]["OrderStatues"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                //mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return trure
                return true;

            }

            else
            {
                return false;
            }

        }



        }
    }

