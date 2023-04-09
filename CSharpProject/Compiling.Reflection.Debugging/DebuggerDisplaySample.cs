using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Compiling.Reflection.Debugging
{
    [DebuggerDisplay("{sampleProperty}", Name = "{sampleName}")]
    internal class DebuggerDisplaySample
    {
        private string sampleName = "";
        public int sampleProperty=4;
    }
}
