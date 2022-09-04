using LanguageExt;

namespace LanguageExtProject;

public class OptionSample
{
    public void main()
    {
        var result = GetSample();
        result.Match(sample => Console.WriteLine("Is Customer"), () => Console.WriteLine("Is null"));
        result.Match(HaveSample, NeedSample);
    }

    private void HaveSample(SampleClass sample)
    {
    }

    private void NeedSample()
    {
    }

    private Option<SampleClass> GetSample()
    {
        return null; //conversion to option
    }

    private class SampleClass
    {
    }
}