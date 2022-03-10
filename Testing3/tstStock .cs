using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
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
    }
}
