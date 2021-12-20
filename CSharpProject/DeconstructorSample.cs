using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class DeconstructorSample
    {
        public static void Sample() {

            var dictionary = new Dictionary<int, int>() { { 1, 1 } };
            var (key, value) = dictionary.First();

            var sample = new DeconstructorSample(1,1);
            var (prop1, prop2) = sample;
        }

        public DeconstructorSample(int sampleInt1, int sampleInt2)
        {
            SampleInt1 = sampleInt1;
            SampleInt2 = sampleInt2;
        }

        public int SampleInt1 { get; }
        public int SampleInt2 { get; }

        public void Deconstruct(out int sampleProp1, out int sampleProp2) {
            sampleProp1 = SampleInt1;
            sampleProp2 = SampleInt2;
        }
    }
}
