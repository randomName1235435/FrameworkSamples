using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class UnsafeSample
    {
        unsafe void SampleMethod() {

            int sampleInteger = 0;

            unsafe
            {
                int* samplePointer = &sampleInteger;
                *samplePointer++;
            }
        }
    }
}
