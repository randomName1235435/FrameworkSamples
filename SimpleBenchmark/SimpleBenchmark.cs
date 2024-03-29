﻿using System;
using System.Diagnostics;

namespace SimpleBenchmark
{
    public class SimpleBenchmark
    {
        public BenchmarkResult Benchmark(Action toBenchmark, bool warmUp = true, int timesToRun = 1)
        {
            var result = new BenchmarkResult(timesToRun);
            if (warmUp)

            {
                Console.WriteLine("Start benchmark warmup");
                for (var k = 0; k < 30; k++) toBenchmark();
                Console.WriteLine("End benchmark warmup");
            }

            var w = new Stopwatch();
            var i = 0;
            var memoryBefore = GC.GetTotalAllocatedBytes();

            while (i < timesToRun)
            {
                w.Reset();
                w.Start();
                {
                    toBenchmark();
                }
                w.Stop();
                result.RunTime[i] = w.ElapsedMilliseconds;
                i++;
            }

            var allocatedMemory = GC.GetTotalAllocatedBytes() - memoryBefore;

            double sum = 0;
            for (var j = 0; j < result.RunTime.Length; j++)
            {
                Console.WriteLine($"Run {j}: {result.RunTime[j]} ms");
                sum += result.RunTime[j];
            }

            var mean = sum / 30;

            Console.WriteLine($"mean: {string.Format("{0:N4}", mean)} ms");
            Console.WriteLine($"allocated memory: {allocatedMemory} b\r\n");

            return result;
        }
    }

    public class BenchmarkResult
    {
        public BenchmarkResult(int countORuntimes)
        {
            RunTime = new long[countORuntimes];
        }

        public long[] RunTime { get; internal set; }
    }
}