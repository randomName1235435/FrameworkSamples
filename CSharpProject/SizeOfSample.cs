using System;

namespace CSharpProject
{
    class SizeOfSample
    {
        void SampleMethod() {
            Console.WriteLine(sizeof(byte));
            Size<byte>();
            Size<SampleStruct>();
        }
        public static unsafe void Size<T>() where T : unmanaged {
            Console.WriteLine(sizeof(T));
        }
    }
    struct SampleStruct {

        public int SampleProperty { get; init; }
        public bool SeconSampleProperty { get; init; }
    }
}
