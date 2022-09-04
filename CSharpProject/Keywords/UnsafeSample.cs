using System;

namespace CSharpProject.Keywords;

internal class UnsafeSample
{
    private unsafe void SampleMethod()
    {
        var sampleInteger = 0;

        var samplePointer = &sampleInteger;
        Console.WriteLine($"value: {*samplePointer}");
        Console.WriteLine($"value: {samplePointer->ToString()}");
    }
}