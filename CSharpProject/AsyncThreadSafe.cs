using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class AsyncThreadSafeSample
    {
        private SemaphoreSlim semaphore = new SemaphoreSlim(1); //lockinstance

        private async Task SampleMethodAsync()
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

        private async Task OtherSampleMethodeAsync()
        {
            await Task.Run(() => Thread.Sleep(1000));
        }
    }
}
