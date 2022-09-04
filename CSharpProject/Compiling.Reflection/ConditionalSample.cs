using System.Diagnostics;

namespace CSharpProject.Compiling.Reflection;

internal class ConditionalSample
{
    //note: methods are compiled but compiler will ignore method call if not compiled with specific config
    [Conditional("DEBUG")]
    private void SampleDebug()
    {
    }

    [Conditional("RELEASE")]
    private void SampleRelease()
    {
    }
}