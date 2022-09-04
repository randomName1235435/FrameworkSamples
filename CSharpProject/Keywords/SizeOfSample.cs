using System;

namespace CSharpProject.Keywords;

internal class SizeOfSample
{
    private void SampleMethod()
    {
        Console.WriteLine(sizeof(byte));
        Size<byte>();
        Size<SampleStruct>();
    }

    public static unsafe void Size<T>() where T : unmanaged
    {
        Console.WriteLine(sizeof(T));
    }
}

internal struct SampleStruct
{
    public int SampleProperty { get; init; }
    public bool SeconSampleProperty { get; init; }
}