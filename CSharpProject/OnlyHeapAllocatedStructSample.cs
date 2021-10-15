
namespace CSharpProject
{
    public ref struct OnlyHeapAllocatedStructSample
    {
        public int SampleProperty { get; set; }
    }
    public class MyClass
    {
        public void Samplemethod()
        {
            var heapAllocatedStruct = new OnlyHeapAllocatedStructSample
            {
                SampleProperty = 0
            };
        }

    }
}
