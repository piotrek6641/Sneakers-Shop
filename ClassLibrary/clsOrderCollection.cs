using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            RecordCount = DB.Count;
            //while there are reecords to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.Statues = Convert.ToByte(DB.DataTable.Rows[Index]["OrderStatues"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //public property for the address list
        public List<clsOrder> OrdersList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mOrderList.Count ;
            }
            set
            {
                //set the private data
                
            }
        }


        public clsOrder ThisOrder { get; set; }
    }
}