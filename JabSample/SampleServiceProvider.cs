using JabSample;
using Jab;

namespace JabSample
{
    [ServiceProvider]
    [Singleton(typeof(ISampleService))]
    [Scoped(typeof(SampleApplication))]
    partial class SampleServiceProvider 
    {
        
    }
}
