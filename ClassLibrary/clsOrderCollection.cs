using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisorder
        clsOrder mThisOrder = new clsOrder();

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }


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
                return mOrderList.Count;
            }
            set
            {
                //set the private data

            }
        }
        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //
            DB.Execute("sproc_tblOrdr_SeletAll");
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
        




        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderStatues", mThisOrder.Statues);
            DB.AddParameter("@Date", mThisOrder.DateAdded);
            return DB.Execute("sproc_TblOrder_Insert");
            //mThisOrder.OrderId = 3;
            //return mThisOrder.OrderId;
        }


    }
}