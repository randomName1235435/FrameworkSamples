using System.Threading;

namespace CSharpProject
{
    class GotoSample
    {
        void SampleMethod() {
            SampleOne:
            Thread.Sleep(0);
            SampleTwo:
            Thread.Sleep(0);
            goto SampleOne;
            goto SampleTwo;
        }
    }
}