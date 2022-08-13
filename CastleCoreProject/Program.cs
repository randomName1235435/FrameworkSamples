using Castle.DynamicProxy;
using CastleCoreProject.Services;
using MemoryCacheSample.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//======================

builder.Services.TryAddSingleton<IProxyGenerator, ProxyGenerator>();
builder.Services.AddSingleton<SampleService>();
builder.Services.TryAddTransient<DurationInterceptor>();
builder.Services.AddSingleton(provider =>
{
    var proxyGenerator = provider.GetRequiredService<IProxyGenerator>();
    var implementation = provider.GetRequiredService<SampleService>();
    var interceptor = provider.GetRequiredService<DurationInterceptor>();
    return proxyGenerator.CreateInterfaceProxyWithTarget<ISampleService>(implementation, interceptor);
});


//======================

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
