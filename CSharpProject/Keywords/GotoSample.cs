using System.Threading;

namespace CSharpProject.Keywords;

internal class GotoSample
{
    private void SampleMethod()
    {
        SampleOne:
        Thread.Sleep(0);
        SampleTwo:
        Thread.Sleep(0);
        goto SampleOne;
        goto SampleTwo;
    }
}