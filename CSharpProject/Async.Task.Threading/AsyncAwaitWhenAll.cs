namespace CSharpProject.Async.Task.Threading;

internal class AsyncAwaitWhenAll
{
    public async void Sample()
    {
        var result1Task = SampleMethod1();
        var result2Task = SampleMethod2();
        var result3Task = SampleMethod3();

        //waiting for all to be completed
        await System.Threading.Tasks.Task.WhenAll(result1Task, result2Task, result3Task);
    }

    public async System.Threading.Tasks.Task SampleMethod1()
    {
        await System.Threading.Tasks.Task.Delay(0);
    }

    public async System.Threading.Tasks.Task SampleMethod2()
    {
        await System.Threading.Tasks.Task.Delay(0);
    }

    public async System.Threading.Tasks.Task SampleMethod3()
    {
        await System.Threading.Tasks.Task.Delay(0);
    }
}