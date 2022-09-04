namespace JabSample;

internal partial class Sample
{
    private static void Main(string[] args)
    {
        var serviceProvider = new SampleServiceProvider();
        var sampleService = serviceProvider.GetService<ISampleService>();
        var sampleApplication = serviceProvider.GetService<SampleApplication>();
    }
}