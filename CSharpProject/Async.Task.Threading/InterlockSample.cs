using System.Threading;

namespace CSharpProject.Async.Task.Threading;

public class InterlockSample
{
    private readonly int sample;

    public InterlockSample()
    {
        Interlocked.Increment(ref sample);
    }
}