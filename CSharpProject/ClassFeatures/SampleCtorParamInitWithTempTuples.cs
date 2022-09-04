namespace CSharpProject.ClassFeatures;

internal class SampleCtorParamInitWithTempTuples
{
    public SampleCtorParamInitWithTempTuples(int sampleProperty1, int sampleProperty2, int optionalProperty = default)
    {
        (SampleProperty1, SampleProperty2, OptionalProperty) = (sampleProperty1, sampleProperty2, optionalProperty);
    }

    public int SampleProperty1 { get; init; }
    public int SampleProperty2 { get; init; }
    public int OptionalProperty { get; }
}