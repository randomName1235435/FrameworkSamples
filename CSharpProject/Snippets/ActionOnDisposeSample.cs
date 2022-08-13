using System;

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
