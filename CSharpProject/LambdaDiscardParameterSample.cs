using System;

namespace CSharpProject
{
    class LambdaDiscardParameterSample
    {
        public void SampleMethod() {

            Action<int, int> sampleAction = (_, _) => Console.WriteLine("");
        }
    }
}
