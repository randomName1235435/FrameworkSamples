using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthCheckSample.Installer
{
    public class HealthCheckInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddHealthChecks().AddDbContextCheck<SampleDataContext>();
        }
    }
}