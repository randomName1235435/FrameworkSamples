using MemoryCacheSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace MemoryCacheSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISampleService sampleService;

        public WeatherForecastController(ISampleService sampleService)
        {
            this.sampleService = sampleService;
        }

        [HttpGet(Name = "GetSample")]
        public async Task<IActionResult> GetSample()
        {
            var sample = await this.sampleService.GetSampleAsync();
            return Ok(sample);
        }
    }
}