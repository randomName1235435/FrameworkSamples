using System;

namespace CSharpProject.Keywords;

internal class LambdaDiscardParameterSample
{
    public void SampleMethod()
    {
        Action<int, int> sampleAction = (_, _) => Console.WriteLine("");
    }
}