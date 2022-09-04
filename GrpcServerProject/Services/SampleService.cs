using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcServerProject.Services
{
    public class SampleService : Sample.SampleBase
    {
        private readonly ILogger<SampleService> _logger;

        public SampleService(ILogger<SampleService> logger)
        {
            _logger = logger;
        }

        public override Task<SampleReply> SampleMethod(SampleMessage request, ServerCallContext context)
        {
            return Task.FromResult(new SampleReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}