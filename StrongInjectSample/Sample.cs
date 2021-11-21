using StrongInject;
using System;

namespace StrongInjectSample
{
    class Sample
    {
        static void Main(string[] args)
        {
            using (var container = new SampleContainer())
            {
                var SampleApplication = container.Resolve().Value;
            }
        }
    }
}
