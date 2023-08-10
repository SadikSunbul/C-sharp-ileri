using Grpc.Core;
using Servic2;

namespace Servic2.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override async Task SayHello(HelloRequest request, IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
        {
           await Task.Run(async () =>
            {
                int count = 0;
                while (++count <= 10)
                {
                    await Task.Delay(1000);
                    await responseStream.WriteAsync(new HelloReply
                    {
                        Message = "Gonderýlen mesaj " + count
                    });
                }
            });
        }
    }
}