using System.Threading;

namespace CSharpProject.Keywords;

internal class VolatileSample
{
    private void SampleMethod()
    {
        var sample = new Sample();
        var sampleThread = new Thread(() => sample.SampleMethod());

        sampleThread.Start();

        while (sampleThread.IsAlive)
        {
        }

        sample.PleaseStop();
    }
}

internal class Sample
{
    private volatile bool shouldStop;

    internal void SampleMethod()
    {
        while (!shouldStop) Thread.Sleep(1000);
    }

    internal void PleaseStop()
    {
        shouldStop = true;
    }
}