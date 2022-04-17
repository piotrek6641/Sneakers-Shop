using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.StaffEmail = "p21561@gmail.com";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffLogin = "123";
            TestItem.StaffPassword = "asd123";
            TestItem.DateCreated = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
            [TestMethod]
            public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.StaffEmail = "p21561@gmail.com";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffLogin = "123";
            TestItem.StaffPassword = "asd123";
            TestItem.DateCreated = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByLoginMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredLogins = new clsStaffCollection();
            FilteredLogins.ReportByLogin("");
            Assert.AreEqual(AllStaff.Count, FilteredLogins.Count);
        }
        [TestMethod]
        public void ReportByLoginNoneFound()
        {
            clsStaffCollection FilteredLogins = new clsStaffCollection();
            FilteredLogins.ReportByLogin("p123");
            Assert.AreEqual(0, FilteredLogins.Count);
        }
        [TestMethod]
        public void ReportByLoginTestDataFound()
        {
            clsStaffCollection FilteredLogins = new clsStaffCollection();
            Boolean OK = true;
            FilteredLogins.ReportByLogin("m123");
            if (FilteredLogins.Count == 2)
            {
                if (FilteredLogins.StaffList[0].StaffID != 2)
                {
                    OK = false;
                }
                if (FilteredLogins.StaffList[1].StaffID != 124)
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
        [TestMethod]
        public void EditMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            
            
            TestItem.StaffEmail = "p21561@gmail.com";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffLogin = "123";
            TestItem.StaffPassword = "asd123";
            TestItem.DateCreated = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            
            TestItem.StaffEmail = "p215611@gmail.com";
            TestItem.StaffIsAdmin = false;
            TestItem.StaffLogin = "1243";
            TestItem.StaffPassword = "asd123a";
            TestItem.DateCreated = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void TestMethod1()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.StaffEmail = "p21561@gmail.com";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffLogin = "123";
            TestItem.StaffPassword = "asd123";
            TestItem.DateCreated = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 0;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.StaffEmail = "p21561@gmail.com";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffLogin = "123";
            TestItem.StaffPassword = "asd123";
            TestItem.DateCreated = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        
    }
}
