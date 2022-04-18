using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class SampleNullCheckThrowArgutmentExc
    {
        public int Sample(int? param) {

            _ = param ?? throw new ArgumentNullException(nameof(param));

            return param.Value;
        }
    }
}
