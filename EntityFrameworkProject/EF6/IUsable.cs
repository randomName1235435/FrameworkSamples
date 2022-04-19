using System;

namespace EntityFrameworkProject.EF6
{
    public interface IUsable<T>
    {
        IUsable<U> Map<U>(Func<T, U> project);
        R Use<R>(Func<T, R> f);
    }
}
