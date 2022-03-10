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
            mSneakerNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mAvailable = true;
            mPrice = 100;
            mSneakerName = "Air Jordan 1";
            return true;
        }
    }
}