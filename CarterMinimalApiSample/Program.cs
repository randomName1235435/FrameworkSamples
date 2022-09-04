using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace CarterMinimalApiSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .ConfigureServices(services => { services.AddCarter(); }).Configure(app =>
                {
                    app.UseRouting();
                    app.UseEndpoints(builder => builder.MapCarter());
                })
                .Build();
            webHost.Run();
        }
    }
}