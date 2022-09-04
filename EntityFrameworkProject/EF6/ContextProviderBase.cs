namespace EntityFrameworkProject.EF6
{
    using System;
    using System.Collections.Generic;

    public abstract class ContextProviderBase<TContext> : IContextProvider<TContext>
        where TContext : class
    {
        protected readonly Dictionary<object, WeakReference<TContext>> openContexts =
            new Dictionary<object, WeakReference<TContext>>(new ReferenceEqualityComparer());

        public TContext Provide(object token = null)
        {
            TContext ctx;

            if (token == null) return CreateContext();

            WeakReference<TContext> weakCtx;

            if (!openContexts.TryGetValue(token, out weakCtx))
            {
                weakCtx = new WeakReference<TContext>(null);
                openContexts[token] = weakCtx;
            }

            weakCtx.TryGetTarget(out ctx);

            if (ctx == null) ctx = CreateContext();

            weakCtx.SetTarget(ctx);
            return ctx;
        }

        protected abstract TContext CreateContext();

        private class ReferenceEqualityComparer : IEqualityComparer<object>
        {
            public bool Equals(object x, object y)
            {
                return x == y;
            }

            public int GetHashCode(object obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}