using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public int SupplierID { get; set; }
        public bool InStock { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string SupplierEmail { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public int StockAmount { get; set; }
    }
}