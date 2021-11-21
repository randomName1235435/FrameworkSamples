using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject
{
    class GotoSample
    {
        void SampleMethod() {
            SampleOne:
            Thread.Sleep(0);
            SampleTwo:
            Thread.Sleep(0);
            goto SampleOne;
            goto SampleTwo;

        }
    }
}
