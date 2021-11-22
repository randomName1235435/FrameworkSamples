namespace EntityFrameworkProject.EF6
{
    using System.Data.Common;
    using System.Data.Entity;

    public partial class SampleContext : DbContext
    {
        public SampleContext(string connectionString)
            : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            this.Database.CommandTimeout = 600;
        }

        public DbConnection Connection
        {
            get { return Database.Connection; }
        }
    }
}

