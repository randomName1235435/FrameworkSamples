using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutofixtureProject
{
    [TestClass]
    public class SampleUnitTestClass
    {
        // works good with xUnit & NUnit see https://github.com/AutoFixture/AutoFixture#overview
        [TestMethod]
        public void TestMethod1()
        {
            var fixture = new Fixture();

            var param = fixture.Create<int>();
            SampleMethod(param);
        }

        private void SampleMethod(int param)
        {
        }
    }
}