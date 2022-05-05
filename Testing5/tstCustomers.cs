using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
	[TestClass]
	public class tstCustomers
	{
		string Customer_email = "bartosh@gmail.com";
		string Phone = "07890575499";
		string Address = "fgdfhgf";
		string DateAdded = DateTime.Now.Date.ToString();
		
		[TestMethod]
		public void TestMethod1ok()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Assert.IsNotNull(AnCustomers);
		}
		[TestMethod]
		public void AvailableSpecialOffersokk()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean TestData = true;
			AnCustomers.Specialoffers = TestData;
			Assert.AreEqual(AnCustomers.Specialoffers, TestData);
		}
		[TestMethod]
		public void DateAddedokk()
		{
			clsCustomers AnCustomers = new clsCustomers();
			DateTime TestData = DateTime.Now.Date;
			AnCustomers.DateAdded = TestData;
			Assert.AreEqual(AnCustomers.DateAdded, TestData);
		}
		[TestMethod]
		public void Customeridokk()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Int32 TestData = 1;
			AnCustomers.Customerid = TestData;
			Assert.AreEqual(AnCustomers.Customerid, TestData);
		}
		[TestMethod]
		public void Customer_emailokk()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String TestData = "norb@gmail.com";
			AnCustomers.Customer_email = TestData;
			Assert.AreEqual(AnCustomers.Customer_email, TestData);
		}
		[TestMethod]
		public void addressokk()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String TestData = "Leicester le27df jarrom street 44";
			AnCustomers.Address = TestData;
			Assert.AreEqual(AnCustomers.Address, TestData);
		}
		[TestMethod]
		public void phoneokk()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String TestData = "07332986400";
			AnCustomers.Phone = TestData;
			Assert.AreEqual(AnCustomers.Phone, TestData);
		}
		[TestMethod]
		public void FindCustomeridfound()
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
		public void FindCustomeremailfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
			if (AnCustomers.Customer_email != "bartosh@gmail.com")
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		
		[TestMethod]
		public void Findaddressfound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
			if (AnCustomers.Address != "Leicesterle15pxpeacocklane99")
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		
		
		[TestMethod]
		public void Findphonefound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
			if (AnCustomers.Phone != "07890575499")
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		
		[TestMethod]
		public void Findifspecialoffersavailablefound()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Boolean Found = false;
			Boolean OK = true;
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
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
			Int32 Customerid = 2;
			Found = AnCustomers.Find(Customerid);
			if (AnCustomers.DateAdded !=Convert.ToDateTime("10/2/2022"))
			{
				OK = false;

			}
			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void ValidMethodOKK()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void Customer_emailMinLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void Customer_emailMin()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "a";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void Customer_emailMinPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "aa";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void Customer_emailMaxLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "";
			Customer_email = Customer_email.PadRight(49, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void Customer_emailMid()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "";
			Customer_email = Customer_email.PadRight(25, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void Customer_emailMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "";
			Customer_email = Customer_email.PadRight(50, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}


		[TestMethod]
		public void Customer_emailMaxPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "";
			Customer_email = Customer_email.PadRight(51, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void Customer_emailExtremeMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Customer_email = "";
			Customer_email = Customer_email.PadRight(500, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void DateAddedExtremeMin()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(-100);
			string DateAdded = TestDate.ToString();
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddDays(-1);
			string DateAdded = TestDate.ToString();
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedMin()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			string DateAdded = TestDate.ToString();
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedMinPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddDays(1);
			string DateAdded = TestDate.ToString();
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedExtremeMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(100);
			string DateAdded = TestDate.ToString();
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedInvalidData()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string DateAdded = "this is not a date!";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void AddressMinLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void AddressMin()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "a";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void AddressMinPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "aa";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void AddressMaxLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "";
			Address = Address.PadRight(49, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void AddressMid()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "";
			Address = Address.PadRight(25, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void AddressMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "";
			Address = Address.PadRight(50, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}


		[TestMethod]
		public void AddressMaxPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "";
			Address = Address.PadRight(51, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void AddressExtremeMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Address = "";
			Address = Address.PadRight(500, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void PhoneLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void PhoneMin()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "a";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void PhoneMinPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "aa";
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void PhoneMaxLessOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "";
			Phone = Phone.PadRight(14, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void PhoneMid()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "";
			Phone = Phone.PadRight(8, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void PhoneMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "";
			Phone = Phone.PadRight(15, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreEqual(Error, "");
		}


		[TestMethod]
		public void PhoneMaxPlusOne()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "";
			Phone = Phone.PadRight(16, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PhoneExtremeMax()
		{
			clsCustomers AnCustomers = new clsCustomers();
			String Error = "";
			string Phone = "";
			Phone = Phone.PadRight(155, 'a');
			Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
			Assert.AreNotEqual(Error, "");
		}


	}
}
