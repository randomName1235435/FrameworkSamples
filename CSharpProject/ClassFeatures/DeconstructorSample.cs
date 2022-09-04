using System.Collections.Generic;
using System.Linq;

namespace CSharpProject.ClassFeatures;

internal class DeconstructorSample
{
    public DeconstructorSample(int sampleInt1, int sampleInt2)
    {
        SampleInt1 = sampleInt1;
        SampleInt2 = sampleInt2;
    }

    public int SampleInt1 { get; }
    public int SampleInt2 { get; }

    public static void Sample()
    {
        var dictionary = new Dictionary<int, int> { { 1, 1 } };
        var (key, value) = dictionary.First();

        var sample = new DeconstructorSample(1, 1);
        var (prop1, prop2) = sample;
    }

    public void Deconstruct(out int sampleProp1, out int sampleProp2)
    {
        sampleProp1 = SampleInt1;
        sampleProp2 = SampleInt2;
    }
}

public class DeconstructExtensionSample
{
    public DeconstructExtensionSample(int sampleInt)
    {
        SampleInt = sampleInt;
    }

    public int SampleInt { get; }
}

public static class DeconstructExtenstion
{
    public static void Deconstruct(this DeconstructExtensionSample deconstructExtensionSample, out int sampleInt)
    {
        sampleInt = deconstructExtensionSample.SampleInt;
    }
}