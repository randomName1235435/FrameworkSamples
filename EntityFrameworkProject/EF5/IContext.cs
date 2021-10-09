using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace EntityFrameworkProject.EF5
{
    public interface IContext : IDisposable
    {
        ConnectionState ConnectionState { get; }

        IDbSet<SamplePoco> SampleTable { get; }
       
        void OpenConnection();
        ObjectResult<int?> SampleStoredProcedure();

        ObjectResult<SampleResultClass> SampleStoredProcedureWithParam(int? sampleIntParam, string sampleStringParam);

        void DetectChanges();

        void SaveChanges();
    }
}