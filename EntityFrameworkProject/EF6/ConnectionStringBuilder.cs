
namespace EntityFrameworkProject.EF6
{
    using System.Data.Entity.Core.EntityClient;
    using System.Data.SqlClient;

    public class ConnectionStringBuilderEF6
    {
        private static string connectionString;

        public static string GetConnectionsString()
        {
            return connectionString ?? (connectionString = GetConnectionStringBuilder().ToString());
        }


        private static EntityConnectionStringBuilder GetConnectionStringBuilder()
        {
            string providerName = "System.Data.SqlClient";
            string serverName = "";
            string databaseName = "";
            var sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = serverName,
                InitialCatalog = databaseName,
                IntegratedSecurity = false,
                UserID = "",
                Password = "",
                PersistSecurityInfo = true
            };
            var providerString = sqlBuilder.ToString();

            var entityBuilder = new EntityConnectionStringBuilder
            {
                Provider = providerName,
                ProviderConnectionString = providerString,
                Metadata = @"res://*/SampleEntities.csdl|res://*/SampleEntities.ssdl|res://*/SampleEntities.msl"
            };
            return entityBuilder;
        }
    }
}
