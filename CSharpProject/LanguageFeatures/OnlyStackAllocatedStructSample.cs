namespace CSharpProject
{
    public ref struct OnlyStackAllocatedStructSample
    {
        public int SampleProperty { get; set; }
    }
    public class MyClass
    {
        public void Samplemethod()
        {
            var stackAllocatedStruct = new OnlyStackAllocatedStructSample
            {
                SampleProperty = 0
            };
        }
    }
}
