using System;

namespace CSharpProject
{
    class StackAllocSample
    {
        void SampleMethod() {
            Span<int> sampleInts = stackalloc int[] { 1, 2, 3, 4, 5 };
        }
    }
}
