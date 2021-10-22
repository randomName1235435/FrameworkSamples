using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpProject
{
   public class ModulInitializerSample
    {
        [ModuleInitializer]
        public static void GetCalledEvenBeforeMain() { }
    }
}
