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

        public string Valid(string customerId, string statues, string dateAdded, string staffId)
        {
            //craete a string variable to store the error
            String Error = "";
            Byte StatuesTemp;
            DateTime DateTemp;
            //if the Statues is blank
            StatuesTemp = Convert.ToByte(statues);
            if (StatuesTemp < 0)
            {
                //record error
                Error = Error + "The statues field cannot be less than 0: ";
            }
            try
            {

                //copy the dateadded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //reecord error
                    Error = Error + "The date cannot be in the past:  ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //reecord error
                    Error = Error + "The date cannot be in the future:  ";
                }
                
            }
            catch
            {
                //record the error
                Error = Error + "The datewas not a valid date:  ";
            }
            //return any error message
            return Error;
        }



    }
    }

