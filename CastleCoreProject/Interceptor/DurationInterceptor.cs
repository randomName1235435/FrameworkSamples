using Castle.DynamicProxy;
using MemoryCacheSample.Services;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace CastleCoreProject.Services
{
    public class DurationInterceptor : IInterceptor
    {
        private readonly ILogger logger;

        public DurationInterceptor(ILogger logger)
        {
            this.logger = logger;
        }
        public void Intercept(IInvocation invocation)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                invocation.Proceed();
            }
            finally
            {

                stopwatch.Stop();
                logger.LogInformation("{methodName} took {elapsedMs}ms", invocation.Method.Name, stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
