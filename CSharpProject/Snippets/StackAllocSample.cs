using System;

namespace CSharpProject.Snippets;

internal class StackAllocSample
{
    private void SampleMethod()
    {
        Span<int> sampleInts = stackalloc int[] { 1, 2, 3, 4, 5 };
    }
}