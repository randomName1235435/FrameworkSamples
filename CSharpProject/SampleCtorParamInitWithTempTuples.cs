using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class SampleCtorParamInitWithTempTuples
    {
        public int SampleProperty1 { get; init; }
        public int SampleProperty2 { get; init; }
        public int OptionalProperty { get; }

        public SampleCtorParamInitWithTempTuples(int sampleProperty1, int sampleProperty2, int optionalProperty = default)
            => (this.SampleProperty1, this.SampleProperty2, this.OptionalProperty) = (sampleProperty1, sampleProperty2, optionalProperty);

    }
}
