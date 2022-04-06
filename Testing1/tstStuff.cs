using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStuff
    {
        [TestMethod]
        public void FindMethodOk()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = aStaff.Find(StaffID); 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestLoginNotFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 1;
            Found = aStaff.Find(StaffID);
            if(aStaff.StaffLogin != "p2613576")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 1;
            Found = aStaff.Find(StaffID);
            if (aStaff.DateCreated != Convert.ToDateTime("2/3/2020"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestPasswordFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 1;
            Found = aStaff.Find(StaffID);
            if (aStaff.StaffPassword != "123")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestisAdminFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 1;
            Found = aStaff.Find(StaffID);
            if (aStaff.StaffIsAdmin != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        public void TestEmailFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 1;
            Found = aStaff.Find(StaffID);
            if (aStaff.StaffEmail != "ppp@gmail.com")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }



        [TestMethod]
        public void InstanceOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.Active = TestData;
            Assert.AreEqual(aStaff.Active, TestData);
        }
        [TestMethod]
        public void DateCreatedPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aStaff.DateCreated = TestData;
            Assert.AreEqual(aStaff.DateCreated, TestData);
            }
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "ppp@gmail.com"; 
            aStaff.StaffEmail = TestData;
            Assert.AreEqual(aStaff.StaffEmail, TestData);
        }
        [TestMethod]
        public void LoginPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "p21315412";
            aStaff.StaffLogin = TestData;
            Assert.AreEqual(aStaff.StaffLogin, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "as213as";
            aStaff.StaffPassword = TestData;
            Assert.AreEqual(aStaff.StaffPassword, TestData);
        }
        [TestMethod]
        public void isAdminPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.StaffIsAdmin = TestData;
            Assert.AreEqual(aStaff.StaffIsAdmin, TestData);
        }

    }

}
