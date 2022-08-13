using System.Runtime.CompilerServices;

namespace CSharpProject
{
    public class ModulInitializerSample
    {
        [ModuleInitializer]
        public static void GetCalledEvenBeforeMain() { }
    }
}
