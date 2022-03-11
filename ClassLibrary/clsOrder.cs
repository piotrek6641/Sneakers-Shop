using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the adress no property
        private Int32 mOrderId;
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        //public object OrderId { get; set; }
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
        public int CustomerId { get; set; }
        public short Statues { get; set; }
        public int StaffId { get; set; }

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 4;
            //always return trure
            return true; 
        }
    }

}