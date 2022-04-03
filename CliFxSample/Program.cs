using CliFx;
using CliFxSample;
using Microsoft.Extensions.DependencyInjection;

static async Task Main(string[] args) => await new CliApplicationBuilder().AddCommandsFromThisAssembly().Build().RunAsync(args);


static async Task<int> MainServiceRegistration()
{
    var services = new ServiceCollection();

    // Register services
    services.AddSingleton<SampleService>();

    // Register commands
    services.AddTransient<SampleCommand>();

    var serviceProvider = services.BuildServiceProvider();

    return await new CliApplicationBuilder()
        .AddCommandsFromThisAssembly()
        .UseTypeActivator(serviceProvider.GetService)
        .Build()
        .RunAsync();
}

