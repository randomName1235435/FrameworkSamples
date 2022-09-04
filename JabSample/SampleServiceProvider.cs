using JabSample;
using Jab;

namespace JabSample;

[ServiceProvider]
[Singleton(typeof(ISampleService), typeof(SampleService))]
[Scoped(typeof(SampleApplication))]
public partial class SampleServiceProvider
{
    public SampleServiceProvider()
    {
    }
}