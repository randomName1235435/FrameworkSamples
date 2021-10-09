using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpProject
{
    public class ReflectionSample
    {

        private static readonly PropertyInfo cachedSampeProperty = typeof(ClassWithPrivatePropertySample)
            .GetProperty("PrivatePropery", BindingFlags.Instance | BindingFlags.NonPublic);

        private static readonly Func<ClassWithPrivatePropertySample, string> getPropertyDelegate =
            (Func<ClassWithPrivatePropertySample, string>)Delegate.CreateDelegate(
                typeof(Func<ClassWithPrivatePropertySample, string>),
                cachedSampeProperty.GetGetMethod(true)!);

        public void SamplePrivatePropCall()
        {
            var param = new ClassWithPrivatePropertySample();
            var privatePropValue = getPropertyDelegate(param);
        }
       
        public class ClassWithPrivatePropertySample
        {
            private string PrivatePropery { get; set; }
        }
    }
}
