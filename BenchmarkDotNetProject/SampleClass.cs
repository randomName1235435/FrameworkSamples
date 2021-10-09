using System;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNetProject
{
    public class SampleMain
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SampleBenchmarkClass>();
            Console.ReadLine();
        }
    }

    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class SampleBenchmarkClass
    {
        [Benchmark]
        public void SampleBenchmarkMethod()
        {
            Thread.Sleep(0);
        }
    }
}
