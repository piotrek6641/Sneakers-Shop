using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we wnt to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 9;
            TestItem.DateAdded  = DateTime.Now.Date;
            TestItem.Statues  = 0;
            TestItem.StaffId = 4;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two value are the samae
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }



        [TestMethod]
        public void ThisOrderPropertytOK()
        {
            //create an instance of the class we wnt to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 9;
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.Statues = 0;
            TestOrder.StaffId = 4;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two value are the samae
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we wnt to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 9;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Statues = 0;
            TestItem.StaffId = 4;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two value are the samae
            Assert.AreEqual(AllOrders.Count , TestList.Count );
        }


    }
}
