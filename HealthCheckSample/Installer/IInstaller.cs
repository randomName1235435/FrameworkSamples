using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthCheckSample.Installer
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection serviceCollection,IConfiguration configuration);
    }
}