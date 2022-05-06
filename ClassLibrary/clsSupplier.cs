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

        public string Valid(string supplierEmail, string address, string phoneNo, string stockAmount, string deliveryDate)
        {
            String Error = "";
            DateTime DateTemp;
            if (supplierEmail.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (supplierEmail.Length > 50)
            {
                Error = Error + "The email must not have more than 50 characters : ";
            }
            if (address.Length == 0)
                        {
                            Error = Error + "The address may not be blank : ";
                        }
                        if (address.Length > 50)
                        {
                            Error = Error + "The address must be less than 9 characters : ";
                        }
                        if (phoneNo.Length == 0)
                        {
                            Error = Error + "The phoneNo may not be blank : ";
                        }
                        if (phoneNo.Length > 50)
                        {
                            Error = Error + "The phoneNo must be less than 50 characters : ";
                        }
                        if (stockAmount.Length == 0)
                        {
                            Error = Error + "The stock amount may not be blank : ";
                        }
                        if (stockAmount.Length > 50)
                        {
                            Error = Error + "The stock amount must be less than 50 characters : ";
                        }
           
            return Error;
        }
    }
}