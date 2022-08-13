using LazyMemoryCacheProject.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLazyCache();
builder.Services.AddSingleton<ISampleService, SampleService>();
builder.Services.AddSingleton<ISampleService>(
    serviceProvider => new CachedSampleService(
        serviceProvider.GetRequiredService<SampleService>()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
