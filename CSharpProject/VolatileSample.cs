using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject
{
    class VolatileSample
    {
        void SampleMethod() {

            var sample = new Sample();
            var sampleThread = new Thread(() => sample.SampleMethod());

            sampleThread.Start();

            while (sampleThread.IsAlive)
            {
            }
            sample.PleaseStop();
        }
    }
    class Sample
    {
        volatile bool shouldStop = false;

        internal void SampleMethod() {
            while (!shouldStop)
            {
                Thread.Sleep(1000);
            }
        }
        internal void PleaseStop()
        {
            shouldStop = true;
        }
    }
}
