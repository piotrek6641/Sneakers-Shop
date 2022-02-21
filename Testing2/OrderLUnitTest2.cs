using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);

        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean TestData = true;
            AnOrderLine.Active = TestData;
            Assert.AreEqual(AnOrderLine.Active, TestData);
        }

        [TestMethod]
        public void OrderLineIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            int TestData = 1;
            AnOrderLine.OrderLineId = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineId, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrderLine AnOrderLineId = new clsOrderLine();
            int TestData = 1;
            AnOrderLineId.OrderId = TestData;
            Assert.AreEqual(AnOrderLineId.OrderId, TestData);
        }

        [TestMethod]
        public void SneakNoPropertyOK()
        {
            clsOrderLine AnOrderLineId = new clsOrderLine();
            int TestData = 1;
            AnOrderLineId.SneakNo = TestData;
            Assert.AreEqual(AnOrderLineId.SneakNo, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrderLine AnOrderLineId = new clsOrderLine();
            int TestData = 1;
            AnOrderLineId.Quantity = TestData;
            Assert.AreEqual(AnOrderLineId.Quantity, TestData);

        }
    }
}
