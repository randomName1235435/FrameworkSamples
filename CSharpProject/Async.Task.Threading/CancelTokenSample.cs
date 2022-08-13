using System;
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
            var result = SampleMethodProperty(token);
            source.Cancel();
            source.CancelAfter(1000);
            source.Token.ThrowIfCancellationRequested();
            source.Dispose();
        }

        private int SampleMethodProperty(CancellationToken token)
        {
            int count = 0;
            while (!token.IsCancellationRequested)
            {
                Thread.Sleep(1000);
                count++;
            }
            return count;
        }
        private Task<int> SampleMethodException(CancellationToken token)
        {

            Func<int> y = new Func<int>(() =>
          {
              int count = 0;
              while (true)
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
          });
            return Task<int>.Factory.StartNew(y, cancellationToken: token);
        }
    }
}
