using System.Data.Common;
using Respawn;
using Respawn.Graph;

namespace RespawnSample;

public class SampleClass
{
    public async Task Sample()
    {
        var checkpoint = new Checkpoint
        {
            TablesToIgnore = new[]
            {
                "sysdiagrams",
                "tblTest",
                "tblObjectType",
                new Table("import", "Task")
            },
            SchemasToExclude = new[]
            {
                "Sample"
            },
            DbAdapter = DbAdapter.SqlServer
        };

        await checkpoint.Reset("MyConnectionStringName");
    }

    public async Task UseConnectionSample(Func<DbConnection> connectionProvider)
    {
        Checkpoint checkpoint = null; // your checkpoint
        await using var conn = connectionProvider();
        await conn.OpenAsync();

        await checkpoint.Reset(conn);
    }
}