using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISampleService, SampleServiceOne>();
builder.Services.AddSingleton<ISampleService, SampleServiceTwo>();

//try add will only register the first service
//builder.Services.TryAddSingleton<ISampleService, SampleServiceOne>();
//builder.Services.TryAddSingleton<ISampleService, SampleServiceTwo>();

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

public interface ISampleService { }

public class SampleServiceOne : ISampleService
{ }
public class SampleServiceTwo : ISampleService
{ }
