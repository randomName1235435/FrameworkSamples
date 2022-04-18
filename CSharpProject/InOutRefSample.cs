using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class InOutRefSample
    {
        public void Usage() {

            int param = 0;

            RefSample(ref param);
        }

        public void RefSample(ref int param) {
            // by ref
            // can modify param

            param = 1;
        }

        public void InSample(in int param)
        {
            // by ref
            // can not (hidden [readonly] attribut on param) modify param

            param = 1; // wont compile
        }

        public void OutSample(out int param)
        {
            // by ref
            // must modify/set param

            param = 1; // wont compile if not set
        }
    }
}
