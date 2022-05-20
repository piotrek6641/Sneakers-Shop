using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {

        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnSupplier.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAmount"]);
                AnSupplier.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);

                mSupplierList.Add(AnSupplier);
                Index++;
            }
        }

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAl");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@PhoneNo", mThisSupplier.PhoneNo);
            DB.AddParameter("@StockAmount", mThisSupplier.StockAmount);
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            DB.AddParameter("@InStock", mThisSupplier.InStock);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@PhoneNo", mThisSupplier.PhoneNo);
            DB.AddParameter("@StockAmount", mThisSupplier.StockAmount);
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            DB.AddParameter("@InStock", mThisSupplier.InStock);

            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByPhoneNo(String PhoneNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneNo", PhoneNo);
            DB.Execute("sproc_tblSupplier_FilterByPhoneNo");
            PopulateArray(DB);
        }
    }
}