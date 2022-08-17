using System;

namespace CSharpProject.Snippets
{
    internal class AttributeOnTypeParameterSample
    {
        internal class ReadonlyAttribute : Attribute
        {
        }
        private void Sample<[Readonly] T>() { 
        
        }
    }
}
