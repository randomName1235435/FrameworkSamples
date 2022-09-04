using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace EntityFrameworkProject.EF5
{
    public partial class SampleEntities : DbContext
    {
        public SampleEntities(string connectionString)
            : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 6000;
        }

        public DbConnection Connection => Database.Connection;

        public IDbSet<SamplePoco> SampleTable { get; internal set; }

        internal ObjectResult<SampleResultClass> SampleStoredProcedureWithParam(int? sampleIntParam,
            string sampleStringParam)
        {
            throw new NotImplementedException();
        }
    }
}