using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
	public class tstCustomers1
	{
		[TestMethod]
		public void TestMethodok()
		{
			clsCustomers AnCustomers = new clsCustomers();
			Assert.IsNotNull(AnCustomers);
		}
	}
}
