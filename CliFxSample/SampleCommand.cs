using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace CliFxSample
{
    [Command]
    internal class SampleCommand : ICommand
    {
        [CommandParameter(0, Description = "required parameter",IsRequired =true)]
        public string SampleParameter { get; set; }

        [CommandOption('o', Description = "OutputParameter", IsRequired = false)]
        public bool OutputParameter { get; set; } = true;

        public async ValueTask ExecuteAsync(IConsole console)
        {
            await console.Output.WriteLineAsync(SampleParameter);
        }
    }
}
