using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSample
{
    internal class ParallelForEachAsAsyncSample
    {
        public static Task ParallelForEachAsAsync<T>(
            IEnumerable<T> source,
            int maxDegreeOfParallelism,
            Func<T, Task> body)
        {
            async Task AwaitPartiton(IEnumerator<T> partition)
            {
                try
                {
                    while (partition.MoveNext())
                    {
                        await body(partition.Current);
                    }
                }
                finally
                {
                    partition.Dispose();
                }
            }
            return Task.WhenAll(
                Partitioner.Create(source)
                    .GetPartitions(maxDegreeOfParallelism)
                    .AsParallel()
                    .Select(AwaitPartiton));
        }
    }
}
