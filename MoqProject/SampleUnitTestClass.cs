using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestFrameworkSamples;

namespace MoqProject
{
    [TestClass]
    public class SampleUnitTestClass
    {
        [TestMethod]
        public void SetupSample()
        {
            var moq = new Mock<ISampleInterface>();
            moq.Setup(x => x.SampleMethod(It.IsAny<string>())).Returns(0);
        }

        [TestMethod]
        public void VerifySample()
        {
            var moq = new Mock<ISampleInterface>();
            moq.Setup(x => x.SampleMethod(It.IsAny<string>())).Returns(0);

            moq.Object.SampleMethod("");
            moq.Verify(x => x.SampleMethod(It.IsAny<string>()), Times.Once());
        }
    }
}