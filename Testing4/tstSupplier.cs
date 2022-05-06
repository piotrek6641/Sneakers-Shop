using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        string supplierEmail = "supply1@gmail.com";
        string address = "1 new street";
        string phoneNo = "11111111111";
        string stockAmount = "100";
        string deliveryDate = "01/01/1111";

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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "a";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "aa";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(50, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(25, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(51, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void supplierEmailMaxExtreme()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(500, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
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
            string deliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
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
            string deliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string deliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
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
            string deliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
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
            string deliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string deliveryDate = "this is not a date";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "a";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "aa";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void addressMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "";
            address = address.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void addressMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "";
            address = address.PadRight(50, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void addressMaxLessOne2()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "";
            address = address.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void addressMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "";
            address = address.PadRight(51, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void addressMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string address = "";
            address = address.PadRight(25, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void phoneNoLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "a";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "aa";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "";
            address = address.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "";
            address = address.PadRight(50, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoLessOne2()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "";
            address = address.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "";
            address = address.PadRight(51, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneNoMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string phoneNo = "";
            address = address.PadRight(25, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }

        

        [TestMethod]
        public void stockAmountLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "a";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "aa";
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "";
            address = address.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "";
            address = address.PadRight(50, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountLessOne2()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "";
            address = address.PadRight(49, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "";
            address = address.PadRight(51, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void stockAmountMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string stockAmount = "";
            address = address.PadRight(25, 'a');
            Error = AnSupplier.Valid(supplierEmail, address, phoneNo, stockAmount, deliveryDate);
            Assert.AreEqual(Error, "");
        }
    }
}
