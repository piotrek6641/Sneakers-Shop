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
	}
}
