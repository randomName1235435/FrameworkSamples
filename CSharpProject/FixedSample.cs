namespace CSharpProject
{
    class FixedSample
    {
        unsafe void SampleMethod()
        {
            string moveAbleSample = "123";
            //fixes a movable allocation, so that the GC dont realloc the variable
            fixed (char* fixedSample = moveAbleSample) { 
            
            }   
        }
    }
}
