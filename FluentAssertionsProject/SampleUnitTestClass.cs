using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentAssertionsProject
{
    [TestClass]
    public class SampleUnitTestClass
    {
        [TestMethod]
        public void SampleShould()
        {
            string result = "";
            result.Should().StartWith("").And.Contain("").And.BeEmpty().And.HaveLength(0);
        }
        [TestMethod]
        public void ShouldThrowExceptionSample()
        {
            Action shouldThrow = () => throw new NotImplementedException();
            shouldThrow.Should().Throw<NotImplementedException>();
        }
    }
}
