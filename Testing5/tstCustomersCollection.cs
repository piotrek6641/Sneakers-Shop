using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstCustomersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomersCollection AllCustomers = new clsCustomersCollection();

            List<clsCustomers> TestList = new List<clsCustomers>();

            clsCustomers TestItem = new clsCustomers();

            TestItem.Specialoffers = true;
            TestItem.Customerid = 2;
            TestItem.Customer_email = "bartosh@gmail.com";
            TestItem.Address = "Leicesterle15pxpeacocklane99";
            TestItem.Phone = "07890575499";
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
        [TestMethod]
        public void ThisCustomerOK()
        {
            clsCustomersCollection AllCustomers = new clsCustomersCollection();

            clsCustomers TestCustomer = new clsCustomers();

            TestCustomer.Specialoffers = true;
            TestCustomer.Customerid = 2;
            TestCustomer.Customer_email = "bartosh@gmail.com";
            TestCustomer.Address = "Leicesterle15pxpeacocklane99";
            TestCustomer.Phone = "07890575499";
            TestCustomer.DateAdded = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestCustomer;
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsCustomersCollection AllCustomers = new clsCustomersCollection();

            List<clsCustomers> TestList = new List<clsCustomers>();

            clsCustomers TestItem = new clsCustomers();

            TestItem.Specialoffers = true;
            TestItem.Customerid = 2;
            TestItem.Customer_email = "bartosh@gmail.com";
            TestItem.Address = "Leicesterle15pxpeacocklane99";
            TestItem.Phone = "07890575499";
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomersCollection AllCustomers = new clsCustomersCollection();

            clsCustomers TestItem = new clsCustomers();
            Int32 PrimaryKey = 0;

            TestItem.Specialoffers = true;
            TestItem.Customerid = 2;
            TestItem.Customer_email = "bartosh@gmail.com";
            TestItem.Address = "Leicesterle15pxpeacocklane99";
            TestItem.Phone = "07890575499";
            TestItem.DateAdded = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.Customerid = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

    }
}
