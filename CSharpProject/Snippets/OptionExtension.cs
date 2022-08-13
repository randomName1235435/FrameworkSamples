using Microsoft.Extensions.DependencyInjection;
using System;


namespace CSharpProject.Snippets
{
    public static class OptionExtensionSample
    {
        public static void AddSample(this IServiceCollection serviceCollection, Action<OptionSample>? options = null)
        {
            serviceCollection.Configure(options);
        }

        public class OptionSample
        {
            public int Sample { get; set; } = 0;
        }
    }
}
