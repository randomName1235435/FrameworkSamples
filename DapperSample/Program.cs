using System.Data;
using Dapper;

namespace DapperSample
{
    public class DapperSampleClass
    {
        public void Main(string[] args)
        {
            var connection = CreateSampleConnection();
            var sample = connection.Query<Sample>("select columname1=@Sample1, columname2=@Sample2");
        }

        private IDbConnection CreateSampleConnection()
        {
            return null;
        }
        private class Sample
        {
            public int Sample1 { get; set; }
            public int Sample2 { get; set; }
        }
    }
}
