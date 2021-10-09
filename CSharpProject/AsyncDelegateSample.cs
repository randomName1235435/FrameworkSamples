using System;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class AsyncDelegateSample
    {
        public async Task SampleMethod() {
            await ExecuteFuncSample(async () =>
            {
                await Task.Delay(0);
            });
        }

        private async Task ExecuteFuncSample(Func<Task> func)
        {
            await Task.Delay(0);
            await func();
        }
    }
}
