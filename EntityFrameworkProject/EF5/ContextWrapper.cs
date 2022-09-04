using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace EntityFrameworkProject.EF5
{
    public class ContextWrapper : IContext
    {
        public ContextWrapper(string connectionstring)
        {
            Context = new SampleEntities(connectionstring);
        }

        public void DetectChanges()
        {
            Context.ChangeTracker.DetectChanges();
        }

        public bool AutoDetectChangesEnabled
        {
            get => Context.Configuration.AutoDetectChangesEnabled;
            set => Context.Configuration.AutoDetectChangesEnabled = value;
        }

        public bool ProxyCreationEnabled
        {
            get => Context.Configuration.ProxyCreationEnabled;
            set => Context.Configuration.ProxyCreationEnabled = value;
        }


        public IDbSet<SamplePoco> SampleTable => Context.SampleTable;

        public SampleEntities Context { get; }

        public virtual ObjectResult<SampleResultClass> SampleStoredProcedureWithParam(int? sampleIntParam,
            string sampleStringParam)
        {
            return Context.SampleStoredProcedureWithParam(sampleIntParam, sampleStringParam);
        }

        public void SaveChanges()
        {
            Context.ChangeTracker.DetectChanges();
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public ConnectionState ConnectionState => Context.Connection.State;

        public void OpenConnection()
        {
            Context.Connection.Open();
        }

        public ObjectResult<int?> SampleStoredProcedure()
        {
            throw new System.NotImplementedException();
        }
    }
}