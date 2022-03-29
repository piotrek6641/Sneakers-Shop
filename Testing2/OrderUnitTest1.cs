using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create test data to pass to the method valid
        string CustomerId = "2";
        string StatuesNo = "0";
        string DateAdded = DateTime.Now.Date.ToString();
        string StaffId = "1";


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
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            System.Int32 OrderId = 2;
            //invoke method
            Found = AnOrder.Find(OrderId);
            // check the adress no
            if (AnOrder.OrderId != 2)
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
            System.Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateAdded != Convert.ToDateTime("22/02/2021"))
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
            System.Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 2)
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
            System.Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Statues != 0)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestOrderStaffFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            System.Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StaffId != 1)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }



        //[TestMethod]
        //public void StatuesNoMinLessOne()
        //{
        //create an isntance of the class we want to create
        //clsOrder AnOrder = new clsOrder();
        //string variable to store any error mesasge
        //String Error = "";
        //create variable to store test data
        //Byte TestStatues;
        // set it to the min
        //TestStatues = 0;
        //create some test dsata to pass the method
        //string StatuesNo = TestStatues.ToString(); ; //this should trigger an error
        //invoke te method
        //Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
        // test to see that the result is correct
        //Assert.AreNotEqual(Error, "");
        //}



        [TestMethod]
        public void StatuesInvalidStatues()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //set the DateAdded to a non date value
            string StatuesNo = "not a statues";
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StatuesNoMin()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            Byte TestStatues;
            // set it to the min
            TestStatues = 0;
            //create some test dsata to pass the method
            string StatuesNo = TestStatues.ToString(); //this should trigger an error
            //invoke te method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StatuesNoMinPlusOne()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            Byte TestStatues;
            // set it to the minplusone
            TestStatues = 0 + 1;
            //create some test dsata to pass the method
            string StatuesNo = TestStatues.ToString(); //this should trigger an error
            //invoke te method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            DateTime TestDate;
            // set it to todays date
            TestDate = DateTime.Now.Date;
            //cahnge the date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            DateTime TestDate;
            // set it to todays date
            TestDate = DateTime.Now.Date;
            //cahnge the date to 1 day  ago
            TestDate = TestDate.AddDays(-1);
            //convert date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            DateTime TestDate;
            // set it to todays date
            TestDate = DateTime.Now.Date;
            //convert date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusPne()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            DateTime TestDate;
            // set it to todays date
            TestDate = DateTime.Now.Date;
            //cahnge the date to 1 in future
            TestDate = TestDate.AddDays(1);
            //convert date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //create variable to store test data
            DateTime TestDate;
            // set it to todays date
            TestDate = DateTime.Now.Date;
            //cahnge the date to 100 years in future 
            TestDate = TestDate.AddYears(100);
            //convert date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an isntance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error mesasge
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "not a date";
            //invoke method
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 TestCustomerId;
            TestCustomerId = 1 - 1;
            string CustomerId = TestCustomerId.ToString();
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 TestCustomerId;
            TestCustomerId = 1;
            string CustomerId = TestCustomerId.ToString();
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 TestCustomerId;
            TestCustomerId = 1 + 1;
            string CustomerId = TestCustomerId.ToString();
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 TestStaffId;
            TestStaffId = 1 - 1;
            string StaffId = TestStaffId.ToString();
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 TestStaffId;
            TestStaffId = 1;
            string StaffId = TestStaffId.ToString();
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 TestStaffId;
            TestStaffId = 1 + 1;
            string StaffId = TestStaffId.ToString();
            Error = AnOrder.Valid(CustomerId, StatuesNo, DateAdded, StaffId);
            Assert.AreEqual(Error, "");
        }

    }
}
