using System.Threading;

namespace CSharpProject.Async.Task.Threading;

internal class AsyncThreadSafeSample
{
    private readonly SemaphoreSlim semaphore = new(1); //lockinstance

    private async System.Threading.Tasks.Task SampleMethodAsync()
    {
        await semaphore.WaitAsync();
        try
        {
            await OtherSampleMethodeAsync();
        }
        finally
        {
            semaphore.Release();
        }
    }

    private async System.Threading.Tasks.Task OtherSampleMethodeAsync()
    {
        await System.Threading.Tasks.Task.Run(() => Thread.Sleep(1000));
    }
}