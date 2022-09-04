using System;
using System.Linq;

namespace SimpleIocContainerSample
{
    public class NoRegistrationsSample
    {
        private static void Main(string[] args)
        {
            var installerImplementations =
                typeof(NoRegistrationsSample).Assembly.ExportedTypes.Where(x =>
                        typeof(ISample).IsAssignableFrom(x)
                        && !x.IsInterface
                        && !x.IsAbstract)
                    .Select(Activator.CreateInstance)
                    .Cast<ISample>()
                    .ToList();

            installerImplementations.ForEach(x => x.Sample());
        }
    }

    public interface ISample
    {
        void Sample();
    }
}