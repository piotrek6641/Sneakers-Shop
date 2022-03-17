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
            AnOrder.Statues = Convert.ToByte(TestData);
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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            // create an instance of the class we want create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            System.Int32 OrderId = 4;
            //invoke method
            Found = AnOrder.Find(OrderId);
            // check the adress no
            if (AnOrder.OrderId != 4)
            {

                OK = false;

            }
            //tst to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            System.Int32 OrderId = 4;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateAdded != Convert.ToDateTime("13/03/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            System.Int32 OrderId = 4;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 4)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatuesFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            System.Int32 OrderId = 4;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Statues != 4)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod ]
        public void TestOrderStaffFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            System.Int32 OrderId = 4;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StaffId != 4)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}
