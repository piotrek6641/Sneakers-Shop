using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{   
 
    [TestClass]
    public class tstStock
    {
        string SneakerName = "Air Jordan 1";
        string DateAdded = DateTime.Now.Date.ToString();
        string Price = "100";

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void AvailableSneakerOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.Available = TestData;
            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void SneakerNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Air Jordan 1";
            AStock.SneakerName = TestData;
            Assert.AreEqual(AStock.SneakerName, TestData);
        }

        [TestMethod]
        public void SneakerNoPropertyOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.SneakerNo = TestData;
            Assert.AreEqual(AStock.SneakerNo, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 60;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 SneakerNo = 3;

            Found = AStock.Find(SneakerNo);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerNo = 3;
            Found = AStock.Find(SneakerNo);
            if(AStock.SneakerNo != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerNo = 3;
            Found = AStock.Find(SneakerNo);
            if (AStock.DateAdded != Convert.ToDateTime("06-02-2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerNo = 3;
            Found = AStock.Find(SneakerNo);
            if (AStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerNo = 3;
            Found = AStock.Find(SneakerNo);
            if (AStock.Price != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSneakerNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerNo = 3;
            Found = AStock.Find(SneakerNo);
            if (AStock.SneakerName != "Smthn")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "AF";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaa";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string SneakerName = "";
            SneakerName = SneakerName.PadRight(500,'a');
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //Date Added tests

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //Price 
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "-1";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "0";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "1";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "99999";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "100000";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "100001";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "50000";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "200000";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //How to write this test? Is it even possible?
        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "swag";
            Error = AStock.Valid(SneakerName, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
    }
}
