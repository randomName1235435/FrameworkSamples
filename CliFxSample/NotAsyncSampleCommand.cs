using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace CliFxSample;

[Command("sampleCommandName")]
internal class NotAsyncSampleCommand : ICommand
{
    [CommandOption('p', Description = "paramName", IsRequired = true)]
    public string SampleParameter { get; set; }

    public ValueTask ExecuteAsync(IConsole console)
    {
        console.Output.WriteLine(SampleParameter);
        return default;
    }
}