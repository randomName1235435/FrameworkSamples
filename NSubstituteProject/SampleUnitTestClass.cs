using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestFrameworkSamples;
using NSubstitute;

namespace NSubstituteProject
{
    [TestClass]
    public class SampleUnitTestClass
    {
        [TestMethod]
        public void SampleSubstitute()
        {
            ISampleInterface sampleSubstitue = Substitute.For<ISampleInterface>();
        }

        [TestMethod]
        public void SampleSubstituteMethod()
        {
            ISampleInterface sampleSubstitue = Substitute.For<ISampleInterface>();
            sampleSubstitue.SampleMethod(Arg.Any<string>()).Returns(0);
        }
    }
}
