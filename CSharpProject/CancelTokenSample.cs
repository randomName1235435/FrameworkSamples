using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject
{
    class CancelTokenSample
    {
        public async void Sample()
        {
            var source = new CancellationTokenSource(1000);
            var token = source.Token;
            var result = await SampleMethod(token);
            source.Cancel();
            source.CancelAfter(1000);
            source.Dispose();
        }

        private Task<int> SampleMethod(CancellationToken token)
        {
            return Task.Run(new Func<CancellationToken, int>(token =>
                           {
                               int count = 0;
                               while (!token.IsCancellationRequested)
                               {
                                   try
                                   {
                                       Thread.Sleep(1000);
                                       count++;
                                   }
                                   catch (TaskCanceledException e)
                                   {
                                       return count;
                                   }
                               }
                               return 0;
                           }),);

        }
    }
}
