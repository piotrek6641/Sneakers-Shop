using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        public void SupplierIDProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 532123;
            AnSupplier.SupplierID = TestData;
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }

        public void InStockProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.InStock = TestData;
            Assert.AreEqual(AnSupplier.InStock, TestData);
        }
        public void DeliveryDateProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DeliveryDate = TestData;
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }

        public void SupplierEmailProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "Supplier@gmail.com";
            AnSupplier.SupplierEmail = TestData;
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
        }

        public void AddressProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "6 new street";
            AnSupplier.Address = TestData;
            Assert.AreEqual(AnSupplier.Address, TestData);
        }

        public void PhoneNoProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "07780367982";
            AnSupplier.PhoneNo = TestData;
            Assert.AreEqual(AnSupplier.PhoneNo, TestData);
        }

        public void StockAmountProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 500;
            AnSupplier.StockAmount = TestData;
            Assert.AreEqual(AnSupplier.StockAmount, TestData);
        }

    }
}
