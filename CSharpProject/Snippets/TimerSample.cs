using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject.Snippets
{
    internal class PeriodicTimerSample
    {
        private async Task Sample(CancellationToken cancellationToken)
        {
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(1));
            while (await periodicTimer.WaitForNextTickAsync(cancellationToken) && !cancellationToken.IsCancellationRequested)
            {
                await DoSOmethingAsync();
            }
        }

        private Task DoSOmethingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
