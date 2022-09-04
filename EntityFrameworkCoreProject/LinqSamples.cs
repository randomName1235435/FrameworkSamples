using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject;

internal class LinqSamples
{
    public void SampleMethod()
    {
        var integerList = new ObserbableMock<int>();
        integerList.Where(x => x > 5).ToQueryString();
    }
}

internal class ObserbableMock<T> : IQueryable<T>
{
    public Expression Expression => throw new NotImplementedException();

    public Type ElementType => throw new NotImplementedException();

    public IQueryProvider Provider => throw new NotImplementedException();

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}