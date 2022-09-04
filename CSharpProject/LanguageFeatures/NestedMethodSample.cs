namespace CSharpProject.LanguageFeatures;

internal class NestedMethodSample
{
    public void SampleMethod()
    {
        SampleNestedMethod(0);

        void SampleNestedMethod(int sampelParamether)
        {
        }
    }
}