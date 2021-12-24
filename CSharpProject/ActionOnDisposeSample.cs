using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ActionOnDisposeSample
    {
        public void Sample()
        {
            using (new ActionOnDispose(() => { /*do stuff*/ }))
            {

            }
        }
    }
    public class ActionOnDispose : IDisposable
    {
        private readonly Action actionOnDispose;

        public ActionOnDispose(Action actionOnDispose)
        {
            this.actionOnDispose = actionOnDispose;
        }
        public void Dispose()
        {
            this.actionOnDispose();
        }
    }
}
