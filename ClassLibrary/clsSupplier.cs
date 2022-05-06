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
        

        public bool Find(int SupplierID)
        {
            tSupplierID = 21;
            tInStock = true;
            tDeliveryDate = Convert.ToDateTime("31/10/2001");
            tSupplierEmail = "supply@gmail.com";
            tAddress = "6 new street";
            tPhoneNo = "07780367982";
            tStockAmount = 500;
            return true;
        }
    }
}