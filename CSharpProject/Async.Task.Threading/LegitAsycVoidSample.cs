using System.Threading.Tasks;

namespace CSharpProject.Async.Task.Threading
{
    internal class LegitAsycVoidSample
    {
        public LegitAsycVoidSample()
        {
            SampleAsycTaskMethod(); // missing await :(
            CallSampleAsycTaskMethod();
        }

        private async void CallSampleAsycTaskMethod()
        {
            await SampleAsycTaskMethod(); //await happyface
        }

        private async Task<Sample> SampleAsycTaskMethod()
        {
            await System.Threading.Tasks.Task.Delay(0);
            return null;
        }

        private class Sample { }
    }

}
