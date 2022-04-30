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

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //
            DB.Execute("sproc_tblOrdr_SeletAll");
            PopulateArray(DB);

        }
        




        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderStatues", mThisOrder.Statues);
            DB.AddParameter("@Date", mThisOrder.DateAdded);
           //DB.AddParameter("@StaffId", mThisOrder.StaffId);
            return DB.Execute("sproc_TblOrdr_Insert");
            
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderStatues", mThisOrder.Statues);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.Execute("sproc_TblOrdr_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.Execute("sproc_TblOrdr_Delete");
        }

        public void ReportByStatues(string Statues)
        {
            Byte StatuesTemp;
            //clsOrderCollection FilteredOrders = new clsOrderCollection();
            StatuesTemp = Convert.ToByte(Statues);
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Statues", StatuesTemp);
            DB.Execute("sproc_TblOrdr_FilterByStatues");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //execute the stored procedure
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
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
    }
}