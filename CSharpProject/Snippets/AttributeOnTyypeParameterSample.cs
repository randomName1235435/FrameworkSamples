using System;

namespace CSharpProject.Snippets
{
    internal class AttributeOnTyypeParameterSample
    {
        internal class ReadonlyAttribute : Attribute
        {
        }
        private void Sample<[Readonly] T>() { 
        
        }
    }
}
