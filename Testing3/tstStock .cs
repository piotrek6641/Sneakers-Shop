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

        public void AvailablePropertyOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.Available = TestData;
            Assert.AreEqual(AStock.Available, TestData);
        }

        public void DateAddedOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        public void SneakerNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Air Jordan 1";
            AStock.SneakerName = TestData;
            Assert.AreEqual(AStock.SneakerName, TestData);
        }

        public void SneakerNoPropertyOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.SneakerNo = TestData;
            Assert.AreEqual(AStock.SneakerNo, TestData);
        }

        public void PricePropertyOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 60;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }
    }
}
