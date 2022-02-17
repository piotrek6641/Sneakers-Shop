using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
	[TestClass]
	public class tstCustomers
	{
		[TestMethod]
		public void TestMethod1()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Assert.IsNotNull(AnCustomers);
		}
		[TestMethod]
		public void AvailableSpecialOffers()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean TestData = true;
			AnCustomers.Specialoffers = TestData;
			Assert.AreEqual(AnCustomers.Specialoffers, TestData);
		}
		[TestMethod]
		public void DateAdded()
		{
			clsCustomers AnCustomers = new clsCustomers();
			DateTime TestData = DateTime.Now.Date;
			AnCustomers.DateAdded = TestData;
			Assert.AreEqual(AnCustomers.DateAdded, TestData);
		}
		[TestMethod]
		public void Customerid()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Int32 TestData = 1;
			AnCustomers.Customerid = TestData;
			Assert.AreEqual(AnCustomers.Customerid, TestData);
		}
		[TestMethod]
		public void Customer_email()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String TestData = "norb@gmail.com";
			AnCustomers.Customer_email = TestData;
			Assert.AreEqual(AnCustomers.Customer_email, TestData);
		}
		[TestMethod]
		public void address()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String TestData = "Leicester le27df jarrom street 44";
			AnCustomers.Address = TestData;
			Assert.AreEqual(AnCustomers.Address, TestData);
		}
		[TestMethod]
		public void phone()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String TestData = "07332986400";
			AnCustomers.Phone = TestData;
			Assert.AreEqual(AnCustomers.Phone, TestData);
		}

	}
}
