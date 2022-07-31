using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkProject.EFCore
{
    class LinqSamples
    {
        public void SampleMethod()
        {
            var integerList = new ObserbableMock<int>();
            integerList.Where(x => x > 5).ToQueryString();
        }
    }
    class ObserbableMock<T> : IQueryable<T>
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
}
