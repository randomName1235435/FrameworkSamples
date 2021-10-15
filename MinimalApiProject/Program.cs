var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => "SampleMessage");
app.Run();