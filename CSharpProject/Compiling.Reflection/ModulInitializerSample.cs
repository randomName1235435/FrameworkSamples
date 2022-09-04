using System.Runtime.CompilerServices;

namespace CSharpProject.Compiling.Reflection;

public class ModulInitializerSample
{
    [ModuleInitializer]
    public static void GetCalledEvenBeforeMain()
    {
    }
}