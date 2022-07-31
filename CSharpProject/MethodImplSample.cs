using System.Runtime.CompilerServices;

namespace CSharpProject
{
    class MethodImplSample
    {
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void SampleMethod() { }
    }
}
