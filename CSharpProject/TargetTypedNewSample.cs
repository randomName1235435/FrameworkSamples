namespace CSharpProject
{
    class TargetTypedNewSample
    {
        TargetTypedNewSample sample = new();

        private TargetTypedNewSample SampleMethodWithParameter(TargetTypedNewSample sample)
        {
            return new();
        }

        private TargetTypedNewSample SampleMethod()
        {
            return SampleMethodWithParameter(new());
        }
    }
}
