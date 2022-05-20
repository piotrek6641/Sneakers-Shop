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
            Int32 IntTemp;

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
                Error = Error + "The Address may not be blank : ";
            }
            if (address.Length > 50)
            {
                Error = Error + "the address must be less than 50 characters : ";
            }
            if (phoneNo.Length == 0)
            {
                Error = Error + "the phone number may not be blank : ";
            }
            if (phoneNo.Length > 50)
            {
                Error = Error + "the phone number must be less than 50 characters : ";
            }
            try
            {
                IntTemp = Convert.ToInt32(stockAmount);
                if (IntTemp < 0)
                {
                    Error = Error + "The stock amount cannot be negative : ";
                }

                if (IntTemp > 100000)
                {
                    Error = Error + "The stock amount cannot be bigger then 100000 : ";
                }
            }
            catch
            {
                Error = Error + "The stock amount has to be integer : ";
            }

            try
            {
                
                DateTemp = Convert.ToDateTime(deliveryDate);
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
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }
    }
}