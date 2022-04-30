using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mSneakerNo;
        private DateTime mDateAdded;
        private Boolean mAvailable;
        private Int32 mPrice;
        private String mSneakerName;

        public int SneakerNo
        {
            get
            {
                return mSneakerNo;
            }
            set
            {
                mSneakerNo = value;
            }
        }
        public bool Available 
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        public DateTime DateAdded { 
            get 
            {
                return mDateAdded;
            } 
            set 
            {
                mDateAdded = value;
            } 
        }
        public string SneakerName 
        {
            get
            {
                return mSneakerName;
            }
            set
            {
                mSneakerName = value;
            }
        }
        public int Price 
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int SneakerNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SneakerNo", SneakerNo);
            DB.Execute("sproc_tblStock_FilterBySneakerNo");

            if(DB.Count == 1)
            {
                mSneakerNo = Convert.ToInt32(DB.DataTable.Rows[0]["SneakerNo"]);
                mSneakerName = Convert.ToString(DB.DataTable.Rows[0]["SneakerName"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(/*string sneakerNo,*/ string sneakerName, string price, string dateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            Int32 IntTemp;

            if (sneakerName.Length == 0)
            {
                Error = Error + "The sneaker name may no be blank : ";
            }

            if(sneakerName.Length > 20)
            {
                Error = Error + "The sneaker name must be less than 20 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
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
            try
            {
                IntTemp = Convert.ToInt32(price);
                if (IntTemp < 0)
                {
                    Error = Error + "The price value cannot be negative : ";
                }

                if (IntTemp > 100000)
                {
                    Error = Error + "The price value cannot be bigger then 100000 : ";
                }
            }
            catch
            {
                Error = Error + "The price has to be integer : ";
            }
            

            return Error;
        }

       
    }
}