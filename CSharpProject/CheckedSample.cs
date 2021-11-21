using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class CheckedSample
    {
        void SampleMethod() {

            int sampleInt = int.MaxValue;

            checked
            {
                sampleInt++; //throws exception
            }

            sampleInt++; // throws no exception but i will be 0

        } 
    }
}
