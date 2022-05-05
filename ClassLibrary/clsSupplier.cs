using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool InStock { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string SupplierEmail { get; set; }
        public string HomeAddress { get; set; }
        public int HouseNo { get; set; }
        public string PhoneNo { get; set; }
        public int StockAmount { get; set; }
    }
}