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
		[TestMethod]
		public void FindCustomerid()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void FindCustomeridnotfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
			if (AnCustomers.Customerid != 2)
			{
				OK = false;
			
			}
			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void FindCustomeremail()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			String Customer_email = "bartosh@gmail.com";
			Found = AnCustomers.Find(Customer_email);
			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void FindCustomeremailnotfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			String Customer_email = "bartosh@gmail.com";
			Found = AnCustomers.Find(Customer_email);
			if (AnCustomers.Customer_email != "bartosh@gmail.com")
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void Findaddress()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			String Address = "Leicester le27df jarrom street 44";
            Found = AnCustomers.Find(Address);
			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void Findaddressnotfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			String Address = "Leicester le27df jarrom street 44";
			Found = AnCustomers.Find(Address);
			if (AnCustomers.Address != "Leicester le27df jarrom street 44")
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void Findphone()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			String Phone = "07332986400";
			Found = AnCustomers.Find(Phone);
			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void Findphonenotfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			String Phone = "07332986400";
			Found = AnCustomers.Find(Phone);
			if (AnCustomers.Phone != "07332986400")
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void Findifspecialoffersavailable()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			String Customer_email = "bartosh@gmail.com";
			Found = AnCustomers.Find(Customer_email);
			if (AnCustomers.Specialoffers != true)
			{
				OK = false;
			}
			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void Findifdateaddedfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			String Customer_email = "bartosh@gmail.com";
			Found = AnCustomers.Find(Customer_email);
			if (AnCustomers.DateAdded != Convert.ToDateTime("2/10/2022"))
			{
				OK = false;
			}
			Assert.IsTrue(OK);
		}




	}
}
