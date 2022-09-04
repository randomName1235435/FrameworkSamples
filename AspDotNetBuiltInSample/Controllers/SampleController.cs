using AspDotNetBuiltInSample;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetBuiltInSample.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly ILogger<SampleController> _logger;
    private readonly IEnumerable<ISampleService> services;
    private readonly ISampleService service;

    public SampleController(ILogger<SampleController> logger, ISampleService service)
    {
        _logger = logger;

        //default is lifo > SampleServiceTwo is injected
        this.service = service;
    }

    public SampleController(ILogger<SampleController> logger, IEnumerable<ISampleService> services)
    {
        _logger = logger;

        //both SampleServices get injected
        this.services = services;
    }

    [HttpGet(Name = "Get")]
    public IEnumerable<SampleDto> Get()
    {
        return null;
    }
}