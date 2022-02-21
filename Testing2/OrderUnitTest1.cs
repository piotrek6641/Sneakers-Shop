using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]

        public void ActivePropertOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean TestData = true;

            AnOrder.Active = TestData;

            Assert.AreEqual(AnOrder.Active, TestData);

        }

        [TestMethod]
        public void DateAddedProprtOK()
        {
            //creating instance
            clsOrder AnOrder = new clsOrder();
            // creating test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            // assign data to property
            AnOrder.DateAdded = TestData;
            // test 2 see the values are ther same
            Assert.AreEqual(AnOrder.DateAdded, TestData);

        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);

        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod] 
        public void StatuesPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int16 TestData = 1;
            AnOrder.Statues = TestData;
            Assert.AreEqual(AnOrder.Statues, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.StaffId = TestData;
            Assert.AreEqual(AnOrder.StaffId, TestData);

        }
    }
}
