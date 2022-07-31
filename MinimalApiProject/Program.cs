using Microsoft.AspNetCore.Builder;

var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => "SampleMessage");
app.MapGet("SampleString", () => "Sample");
app.MapGet("Sample", () => new Sample("sample", 0));
app.Run();


//alternativ
//var app = WebApplication.Create();
//app.Run();

record Sample(string FirstSampleProperty, int SecondSampleProperty);

