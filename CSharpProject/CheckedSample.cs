namespace CSharpProject
{
    class CheckedSample
    {
        void SampleMethod()
        {
            int sampleInt = int.MaxValue;

            checked
            {
                sampleInt++; //throws exception
            }

            sampleInt++; // throws no exception but i will be 0

        }
    }
}
