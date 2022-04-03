using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using System.Text;

namespace CliFxSample
{
    [Command]
    internal class SampleCommand : ICommand
    {
        [CommandParameter(0, Description = "required parameter", IsRequired = true)]
        public string SampleParameter { get; set; }

        [CommandOption('o', Description = "OutputParameter", IsRequired = false)]
        public bool OutputParameter { get; set; } = true;

        [CommandOption("token", IsRequired = true, EnvironmentVariable = "AUTH_TOKEN")]
        public string EnvironmentVariablesSample { get; init; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            CancellationToken cancellation = console.RegisterCancellationHandler();
            await console.Output.WriteLineAsync(new StringBuilder(SampleParameter), cancellation);
        }
    }
}
