using System.DirectoryServices;

namespace DotNetFrameworkSample
{
    internal class SampleActiveDirectoryReader
    {
        public void GetDataSample()
        {
            //note: in ldap connectionstring 'LDAP' need to be in uppercase
            const string serverIp = "0.0.0.0";
            const string dcName1 = "sampleName";
            const string dcName2 = "sampleName";
            const string dcName3 = "com";
            const string user = "sampleUser";
            const string pw = "samplePw";
            const string domain = "sampleDomain";
            var dirE = new DirectoryEntry($"LDAP://{serverIp}/CN=Users,DC={dcName1},DC={dcName2},DC={dcName3}",
                $@"{domain}\{user}", pw);
            var dirS = new DirectorySearcher(dirE);

            dirS.PageSize = 100;
            dirS.Filter = "(&(objectClass=User)(sAMAccountName=" + user + "))";

            var result = dirS.FindOne();
        }
    }
}