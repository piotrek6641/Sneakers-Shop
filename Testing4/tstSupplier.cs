using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        string SupplierEmail = "supply1@gmail.com";
        string Address = "1 new street";
        string PhoneNo = "11111111111";
        string StockAmount = "100";
        string DeliveryDate = DateTime.Now.Date.ToString();

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
            if (AnSupplier.DeliveryDate != Convert.ToDateTime("01/01/1111"))
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
            if (AnSupplier.Address != "1 newer street")
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void supplierEmailMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "a";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void supplierEmailMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "aa";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void supplierEmailMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(49, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void supplierEmailMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(50, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void supplierEmailMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(25, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void supplierEmailMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(51, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMaxExtreme()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(500, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string DeliveryDate = "this is not a date";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "a";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "aa";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void addressMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void addressMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void addressMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void addressMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNoLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "a";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "aa";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(49, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(50, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNoMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(51, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(25, 'a');
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void stockAmountLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "-1";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "1";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "2";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "99999";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "100000";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void stockAmountMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "100001";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StockAmount = "50000";
            Error = AnSupplier.Valid(SupplierEmail, Address, PhoneNo, StockAmount, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void InstanceOK ()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
        }
        
    }
}
