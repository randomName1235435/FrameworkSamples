/*
 Simple standalone sample:
CoconaApp.Run((string path, int length) =>
{
	Console.WriteLine(path + length);
});
 */

using Cocona;
using CoconaSample;
using Microsoft.Extensions.DependencyInjection;

var builder = CoconaApp.CreateBuilder();
builder.Services.AddSingleton<ServiceToInjectSample>();
var app = builder.Build();
app.AddCommand("me", (string path, int length) => { Console.WriteLine(path + length); });
app.AddCommand("sample", (ServiceToInjectSample service) =>
{
    service.DoSomething();
    Console.WriteLine(service.GetTextMessage());
});
//calling: dotnet run sample
//calling: dotnet run me
app.Run();

namespace CoconaSample
{
    public class ServiceToInjectSample
    {
        public void DoSomething()
        {
        }

        public string GetTextMessage()
        {
            return string.Empty;
        }
    }
}