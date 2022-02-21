using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public object OrderId { get; set; }
        public int CustomerId { get; set; }
        public short Statues { get; set; }
        public int StaffId { get; set; }
    }
}