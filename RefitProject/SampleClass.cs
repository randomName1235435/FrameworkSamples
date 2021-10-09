using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefitProject
{
    public interface ISampleInterfaceService
    {
        [Get("/Sample/{sample}")]
        Task<SampleResultClass> GetSample(string user);

        [Get("/Sample/list?sort=desc")]
        Task<List<SampleResultClass>> GetSampleOrdered();

        [Get("/sample/{id}/sample")]
        Task<List<SampleResultClass>> Sample([AliasAs("id")] int sampleId);
    }
    public class SampleClass {
        public async Task SampleMethod() {
            var sampleApiService = RestService.For<ISampleInterfaceService>("https://sampleAdress");
            var result = await sampleApiService.GetSample("sample");
        }
    }
}
