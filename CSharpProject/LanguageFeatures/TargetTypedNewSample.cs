namespace CSharpProject.LanguageFeatures;

internal class TargetTypedNewSample
{
    private TargetTypedNewSample sample = new();

    private TargetTypedNewSample SampleMethodWithParameter(TargetTypedNewSample sample)
    {
        return new TargetTypedNewSample();
    }

    private TargetTypedNewSample SampleMethod()
    {
        return SampleMethodWithParameter(new TargetTypedNewSample());
    }
}