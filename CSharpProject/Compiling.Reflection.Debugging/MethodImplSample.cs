using System.Runtime.CompilerServices;

namespace CSharpProject.Compiling.Reflection;

internal class MethodImplSample
{
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SampleMethod()
    {
    }
}