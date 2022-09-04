using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using MinimalApiProject;

var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => "SampleMessage");
app.MapGet("SampleString", () => "Sample");
app.MapGet("Sample", () => new Sample("sample", 0));
app.MapGet("Samples", CreateSample);

static async Task CreateSample(ISampleService sampleService)
{
    await sampleService.Create();
}

app.Run();


//alternativ
//var app = WebApplication.Create();
//app.Run();

namespace MinimalApiProject
{
    internal record Sample(string FirstSampleProperty, int SecondSampleProperty);
}