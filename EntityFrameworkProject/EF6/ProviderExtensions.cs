using System;

namespace EntityFrameworkProject.EF6
{
    public static class ProviderExtensions
    {
        public static R Use<T1, R>(this Func<T1> @this, Func<T1, R> usage) where T1 : IDisposable
        {
            using (var ctx = @this())
            {
                return usage(ctx);
            }
        }
    }
}
