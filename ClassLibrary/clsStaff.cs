using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateCreated { get; set; }
        public bool StaffIsAdmin { get; set; }
        public string StaffPassword { get; set; }
        public string StaffLogin { get; set; }
        public string StaffEmail { get; set; }
    }
}