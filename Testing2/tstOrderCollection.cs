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
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Statues = 0;
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
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //TestItem.CustomerId = 5;
            TestItem.Statues = 0;
            TestItem.DateAdded = DateTime.Now.Date;
            //TestItem.StaffId = 4;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        //[TestMethod]
        //public void DeleteMethodOK()
        //{
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    clsOrder TestItem = new clsOrder();
        //    Int32 PrimaryKey = 0;
        //    TestItem.CustomerId = 5;
        //    TestItem.Statues = 0;
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    TestItem.StaffId = 4;
        //    AllOrders.ThisOrder = TestItem;
        //    PrimaryKey = AllOrders.Add();
        //    TestItem.OrderId = PrimaryKey;
        //    AllOrders.ThisOrder.Find(PrimaryKey);
        //    Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        //}


        [TestMethod]
        public void UpdateMethodOK()

        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 5;
            TestItem.Statues = 0;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffId = 4;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;
            TestItem.CustomerId = 1;
            TestItem.Statues = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffId = 1;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);


            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 5;
            TestItem.Statues = 0;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffId = 4;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStatuesMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByStatues("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStatuesNoneFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            FilteredOrder.ReportByStatues("3");
            Assert.AreEqual(0, FilteredOrder.Count);
        }

        [TestMethod]
        public void ReportByStatuesTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByStatues("3");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrdersList[0].OrderId != 1)
                {
                    OK = false;
                }
                if (FilteredOrders.OrdersList[1].OrderId != 23)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
