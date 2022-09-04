using StrongInject;
using System;

namespace StrongInjectSample
{
    internal class Sample
    {
        private static void Main(string[] args)
        {
            using (var container = new SampleContainer())
            {
                var SampleApplication = container.Resolve().Value;
            }
        }
    }
}