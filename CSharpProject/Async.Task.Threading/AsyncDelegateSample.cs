using System;

namespace CSharpProject.Async.Task.Threading;

public class AsyncDelegateSample
{
    public async System.Threading.Tasks.Task SampleMethod()
    {
        await ExecuteFuncSample(async () => { await System.Threading.Tasks.Task.Delay(0); });
    }

    private async System.Threading.Tasks.Task ExecuteFuncSample(Func<System.Threading.Tasks.Task> func)
    {
        await System.Threading.Tasks.Task.Delay(0);
        await func();
    }
}