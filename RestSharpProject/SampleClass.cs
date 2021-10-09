using System;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace RestSharpProject
{
    public class SampleClass
    {
        public void SampleMethod()
        {

            var client = new RestClient("https://api.twitter.com/1.1");
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            var response = client.Get(request);
        }

        public async Task SampleAsyncMethod()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var client = new RestClient("https://api.twitter.com/1.1");
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            var timeline = await client.GetAsync<SampleResultClass>(request, cancellationTokenSource.Token);
        }
    }
}
