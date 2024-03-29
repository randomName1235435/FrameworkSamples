﻿namespace CSharpProject.Keywords;

internal class RecordSample
{
    public void SampleMethod()
    {
        var sample = new SampleRecord("Sample", 1);
        var sampleWith = sample with { SampleIntProperty = 2 };

        var sampleInitRecord = new SampleInitRecord { SampleProperty = 5 };
    }

    private record SampleBase
    {
    }

    private record SampleDerived : SampleBase
    {
        public SampleDerived(SampleBase baseClass) : base(baseClass)
        {
        }
        // properties from base will get copied
    }
}

internal record SampleRecord(string SampleStringProperty, int SampleIntProperty);

internal abstract record SampleAbstractRecord(string SampleStringProperty, int SampleIntProperty)
{
    protected virtual void SampleVirtualMethod()
    {
    }

    protected abstract void SampleAbstractMethod();
}

internal record SampleInitRecord
{
    public int SampleProperty { get; init; }
}