namespace CSharpProject.Keywords;

internal class CheckedSample
{
    private void SampleMethod()
    {
        var sampleInt = int.MaxValue;

        checked
        {
            sampleInt++; //throws exception
        }

        sampleInt++; // throws no exception but i will be 0
    }
}