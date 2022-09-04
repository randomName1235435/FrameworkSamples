using Carter;
using Carter.ModelBinding;
using Carter.Response;
using Carter.Request;
using Carter.OpenApi;
using System;
using Microsoft.AspNetCore.Http;


namespace CarterMinimalApiSample
{
    public class SampleModule : CarterModule
    {
        public SampleModule()
        {
            Get("/Sample", async (request, response) => { await response.WriteAsync("SampleResponse"); });
            Post("/Sample", async (request, response) =>
            {
                var sample = await request.Bind<SampleClass>();
                await response.WriteAsJsonAsync(sample);
            });
        }
    }

    public class SampleClass
    {
        public SampleClass(string sampleStringProperty, int sampleIntProperty)
        {
            SampleStringProperty = sampleStringProperty;
            SampleIntProperty = sampleIntProperty;
        }

        private string SampleStringProperty { get; set; }
        private int SampleIntProperty { get; set; }
    }
}