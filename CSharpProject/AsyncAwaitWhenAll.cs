using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class AsyncAwaitWhenAll
    {

        public async void Sample() {

            var result1Task = SampleMethod1();
            var result2Task = SampleMethod2();
            var result3Task = SampleMethod3();

            //waiting for all to be completed
            await Task.WhenAll(result1Task, result2Task, result3Task);
        }

        public async Task SampleMethod1()
        {
            await Task.Delay(0);
        }
        public async Task SampleMethod2()
        {
            await Task.Delay(0);
        }
        public async Task SampleMethod3()
        {
            await Task.Delay(0);
        }
    }
}
