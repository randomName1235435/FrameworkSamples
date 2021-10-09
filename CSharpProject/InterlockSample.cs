using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpProject
{
    public class InterlockSample
    {
        int sample = 0;
        public InterlockSample()
        {
            Interlocked.Increment(ref sample);
        }
        
    }
}
