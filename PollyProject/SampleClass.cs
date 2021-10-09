using Polly;
using Polly.Retry;
using System;
using System.Threading.Tasks;

namespace PollyProject
{
    public class SampleClass
    {
        private const int maxTrys = 5;
        private const int timeout = 1000;
        RetryPolicy<int> retryPolicy = Policy<int>.Handle<Exception>().Retry(maxTrys);
        AsyncRetryPolicy<int> asyncRetryPolicy = Policy<int>.Handle<Exception>().RetryAsync(maxTrys);

        public void SampleRetryMethod()
        {

            var ret = retryPolicy.Execute(() => MaybeThrowException());
        }

        public void SampleDelayBetweenTrysMethod()
        {

            retryPolicy = Policy<int>.Handle<Exception>().WaitAndRetry(maxTrys, times => TimeSpan.FromMilliseconds(timeout));
        }
        public void SampleExceptionFilterMethod()
        {

            retryPolicy = Policy<int>.Handle<Exception>(
                ex =>
                {
                    return ex is DivideByZeroException || ex.Message == "sample";
                }).Retry(maxTrys);
        }

        public void SampleRetryMethodAsync()
        {

            var ret = asyncRetryPolicy.ExecuteAsync(async () => await MaybeThrowExceptionAsync());
        }

        public int MaybeThrowException() { return 0; }

        public async Task<int> MaybeThrowExceptionAsync() { return 0; }
    }
}
