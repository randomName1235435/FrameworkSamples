using MemoryCacheSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace CastleCoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService sampleService;

        public SampleController(ISampleService sampleService)
        {
            this.sampleService = sampleService;
        }

        [HttpGet(Name = "GetSample")]
        public async Task<IActionResult> GetSample()
        {
            var sample = await sampleService.GetSampleAsync();
            return Ok(sample);
        }
    }
}