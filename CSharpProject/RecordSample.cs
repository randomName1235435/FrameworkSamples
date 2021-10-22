namespace CSharpProject
{
    class RecordSample
    {
        public void SampleMethod()
        {
            var sample = new SampleRecord("Sample", 1);
            var sampleWith = sample with { SampleIntProperty = 2 };
        }
    }
    internal record SampleRecord(string SampleStringProperty, int SampleIntProperty);
}
