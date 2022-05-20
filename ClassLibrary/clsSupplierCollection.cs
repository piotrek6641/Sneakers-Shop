using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {

        List<clsSupplier> mSupplierList = new List<clsSupplier>();

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
        public clsSupplier ThisSupplier { get; set; }
    }
}