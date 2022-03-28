using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList { 
            get 
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            } 
        }
        public int Count { 
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock { 
            get 
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            
            while(Index < RecordCount)
            {
                clsStock AStock = new clsStock();

                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.SneakerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SneakerNo"]);
                AStock.SneakerName = Convert.ToString(DB.DataTable.Rows[Index]["SneakerName"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);

                mStockList.Add(AStock);

                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SneakerName", mThisStock.SneakerName);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SneakerNo", mThisStock.SneakerNo);
            DB.AddParameter("@SneakerName", mThisStock.SneakerName);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);

            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SneakerNo", mThisStock.SneakerNo);
            DB.Execute("sproc_tblStock_Delete");
        }
    }
}