using Sigil;
using System;
using System.Reflection;

namespace SigilProject
{
    public class SampleClass
    {
        private static readonly Type maybeInternalClassType =
            Type.GetType("CSharpProject.ClassWithPrivatePropertySample, CSharpProject");

        private static readonly PropertyInfo maybeInternalProperty =
            maybeInternalClassType.GetProperty("PrivatePropery", BindingFlags.Instance | BindingFlags.NonPublic);


        private static readonly Emit<Func<object, string>> getProperyErmitterSample =
            Emit<Func<object, string>>.NewDynamicMethod("GetPrivatePropertyValue")
                .LoadArgument(0)
                .CastClass(maybeInternalClassType)
                .Call(maybeInternalProperty.GetGetMethod(true)!)
                .Return();

        private static readonly Func<object, string> GetPropertyErmittedDelegate =
            getProperyErmitterSample.CreateDelegate();

        public void CallPrivateProperySample()
        {
            var privateClassInstance = Activator.CreateInstance(maybeInternalClassType);
            var result = GetPropertyErmittedDelegate(privateClassInstance);
        }

        private class ClassWithPrivatePropertySample
        {
            private string PrivatePropery { get; set; }
        }
    }
}