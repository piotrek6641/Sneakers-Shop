using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            TestList.Add(TestItem);

            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 SomeCount = 0;
            AllSupplier.Count = SomeCount;
            Assert.AreEqual(AllSupplier.Count, SomeCount);
        }
        
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();

            TestSupplier.InStock = true;
            TestSupplier.PhoneNo = "+44 1111111111";
            TestSupplier.StockAmount = 100;
            TestSupplier.SupplierEmail = "new@new.com";
            TestSupplier.Address = "1 new street";
            TestSupplier.DeliveryDate = DateTime.Now.Date;
            TestSupplier.SupplierID = 1;

            AllSupplier.ThisSupplier = TestSupplier;

            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            TestList.Add(TestItem);

            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.AreEqual(AllSupplier.Count, 2);
        }
    }
}
