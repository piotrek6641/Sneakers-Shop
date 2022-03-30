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
      
    }
}
