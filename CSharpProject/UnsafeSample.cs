using System;

namespace CSharpProject
{
    class UnsafeSample
    {
        unsafe void SampleMethod() {

            int sampleInteger = 0;

            unsafe
            {
                int* samplePointer = &sampleInteger;
                Console.WriteLine($"value: {*samplePointer}");
                Console.WriteLine($"value: {samplePointer->ToString()}");
            }
        }
    }
}
