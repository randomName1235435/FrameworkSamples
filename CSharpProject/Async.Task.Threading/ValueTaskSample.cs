using System;
using System.Threading.Tasks;

namespace CSharpProject.Async.Task.Threading;

internal class ValueTaskSample
{
    public async ValueTask<int> SampleValueTaskMethod()
    {
        //90% chance that we dont need a real task object so we can use a valueTask for less mem alloc
        var random = new Random(DateTime.Now.Millisecond);
        if (random.Next(0, 10) == 0)
        {
            var x = new Func<Task<int>>(async () =>
            {
                await System.Threading.Tasks.Task.Delay(0);
                return 0;
            });
            return await x();
        }

        return 0;
    }
}