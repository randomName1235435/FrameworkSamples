using System;

namespace EntityFrameworkProject.EF6
{
    public static class Usable
    {
        public static IUsable<T> Create<T>() where T : IDisposable, new()
        {
            return new Impl<T, T>(() => new T(), x => x.Dispose(), x => x);
        }

        public static IUsable<TProjection> Create<T, TProjection>(Func<T, TProjection> project) where T : IDisposable, new()
        {
            return new Impl<T, TProjection>(() => new T(), x => x.Dispose(), project);
        }

        public static IUsable<T> Create<T>(Func<T> create) where T : IDisposable
        {
            return new Impl<T, T>(create, x => x.Dispose(), x => x);
        }

        public static IUsable<TProjection> Create<T, TProjection>(Func<T> create, Func<T, TProjection> project) where T : IDisposable
        {
            return new Impl<T, TProjection>(create, x => x.Dispose(), project);
        }

        public static IUsable<T> Create<T>(Func<T> create, Action<T> destroy)
        {
            return new Impl<T, T>(create, destroy, x => x);
        }

        public static IUsable<TProjection> Create<T, TProjection>(Func<T> create, Action<T> destroy, Func<T, TProjection> project)
        {
            return new Impl<T, TProjection>(create, destroy, project);
        }

        public class Impl<T, TProjection> : IUsable<TProjection>
        {
            private readonly Func<T> create;
            private readonly Action<T> destroy;

            private readonly Func<T, TProjection> project;

            public Impl(Func<T> create, Action<T> destroy, Func<T, TProjection> project)
            {
                this.create = create;
                this.destroy = destroy;
                this.project = project;
            }

            public IUsable<TProjection2> Map<TProjection2>(Func<TProjection, TProjection2> project)
            {
                return new Impl<T, TProjection2>(this.create, this.destroy, x => project(this.project(x)));
            }

            public R Use<R>(Func<TProjection, R> f)
            {
                var ctx = this.create();

                try
                {
                    return f(this.project(ctx));
                }
                finally
                {
                    this.destroy(ctx);
                }
            }
        }
    }
}
