using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void supplier()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }
        [TestMethod]
        public void SupplierIDProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 532123;
            AnSupplier.SupplierID = TestData;
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }
        [TestMethod]
        public void InStockProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.InStock = TestData;
            Assert.AreEqual(AnSupplier.InStock, TestData);
        }
        [TestMethod]
        public void DeliveryDateProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DeliveryDate = TestData;
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }
        [TestMethod]
        public void SupplierEmailProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "Supplier@gmail.com";
            AnSupplier.SupplierEmail = TestData;
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
        }
        [TestMethod]
        public void AddressProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "6 new street";
            AnSupplier.Address = TestData;
            Assert.AreEqual(AnSupplier.Address, TestData);
        }
        [TestMethod]
        public void PhoneNoProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "07780367982";
            AnSupplier.PhoneNo = TestData;
            Assert.AreEqual(AnSupplier.PhoneNo, TestData);
        }
        [TestMethod]
        public void StockAmountProperties()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 500;
            AnSupplier.StockAmount = TestData;
            Assert.AreEqual(AnSupplier.StockAmount, TestData);
        }
        [TestMethod]
        public void FindMethod()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierNoFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.SupplierID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryDateFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.DeliveryDate !=Convert.ToDateTime("01/01/1111"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplyEmailFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.SupplierEmail != "supply1@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Address != "1 new street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNoFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.PhoneNo != "11111111111")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockAmountFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.StockAmount != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
