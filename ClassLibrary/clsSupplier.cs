using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 tSupplierID;
        public Int32 SupplierID
        {
            get
            {
                return tSupplierID;
            }
            set
            {
                tSupplierID = value;
            }
        }
        private bool tInStock;
        public bool InStock
        {
            get
            {
                return tInStock;
            }
            set
            {
                tInStock = value;
            }
        }
        private DateTime tDeliveryDate;
        public DateTime DeliveryDate
        {
            get
            {
                return tDeliveryDate;
            }
            set
            {
                tDeliveryDate = value;
            }
        }
        private string tSupplierEmail;
        public string SupplierEmail
        {
            get
            {
                return tSupplierEmail;
            }
            set
            {
                tSupplierEmail = value;
            }
        }
        private string tAddress;
        public string Address
        {
            get
            {
                return tAddress;
            }
            set
            {
                tAddress = value;
            }
        }
        private string tPhoneNo;
        public string PhoneNo
        {
            get
            {
                return tPhoneNo;
            }
            set
            {
                tPhoneNo = value;
            }
        }
        private Int32 tStockAmount;
        public Int32 StockAmount
        {
            get
            {
                return tStockAmount;
            }
            set
            {
                tStockAmount = value;
            }
        }
        

        public bool Find(Int32 SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                tSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                tSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                tAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                tPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                tStockAmount = Convert.ToInt32(DB.DataTable.Rows[0]["StockAmount"]);
                tInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                tDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}