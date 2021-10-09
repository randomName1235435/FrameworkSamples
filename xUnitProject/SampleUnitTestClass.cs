using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Xunit;

namespace xUnitProject
{
    public class SampleUnitTestClass
    {
        [Fact]
        public void SimpleTest()
        {
        }
        [Fact]
        public async Task AsyncSample()
        {
            await Task.Delay(0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void MultiDataSample(int param)
        {
        }
    }
}
