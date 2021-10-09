using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTest
{
    [TestClass]
    public class SampleUnitTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExpectedException()
        {
            throw new Exception();
        }
    }
}
