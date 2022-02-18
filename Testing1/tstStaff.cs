using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clcLogin ALoggin = new clsLogin();
            Assert.isNotNull(ALoggin);
        }
    }
}
