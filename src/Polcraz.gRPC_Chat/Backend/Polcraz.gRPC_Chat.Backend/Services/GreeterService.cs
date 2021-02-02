using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Polcraz.gRPC_Chat.Protos;

namespace Polcraz.gRPC_Chat.Backend
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Message from " + request.Name
            });
        }
    }
}
