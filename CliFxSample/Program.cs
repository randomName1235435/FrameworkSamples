using CliFx;

static async Task Main(string[] args) => await new CliApplicationBuilder().AddCommandsFromThisAssembly().Build().RunAsync(args);