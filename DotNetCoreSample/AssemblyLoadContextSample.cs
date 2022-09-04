using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Loader;

namespace DotNetCoreSample
{
    internal class AssemblyLoadContextSample : AssemblyLoadContext
    {
        private void Sample()
        {
            //replacement for appDomains
            var context = new AssemblyLoadContextSample();
            var jsonInContext = context.LoadFromAssemblyName(new System.Reflection.AssemblyName("Newtonsoft.Json"));

            var jObjectType = jsonInContext.GetType(typeof(JObject).FullName);
            var obj = Activator.CreateInstance(jObjectType);

            var jObjInContext = (JObject)obj;
        }
    }
}