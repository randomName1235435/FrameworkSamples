namespace CSharpProject.Keywords;

internal class FixedSample
{
    private unsafe void SampleMethod()
    {
        var moveAbleSample = "123";
        //fixes a movable allocation, so that the GC dont realloc the variable
        fixed (char* fixedSample = moveAbleSample)
        {
        }
    }
}