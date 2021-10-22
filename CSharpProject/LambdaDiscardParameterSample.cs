using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class LambdaDiscardParameterSample
    {
        public void SampleMethod() {

            Action<int, int> sampleAction = (_, _) => Console.WriteLine("");
        }
    }
}
