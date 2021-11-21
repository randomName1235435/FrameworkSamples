using Jab;
using System;

namespace JabSample
{
    
    partial class Sample
    {
        static void Main(string[] args)
        {
            var serviceProvider = new SampleServiceProvider();
            var sampleService = serviceProvider.GetService<ISampleService>();
            var sampleApplication = serviceProvider.GetService<SampleApplication>();

        }
    }

}
