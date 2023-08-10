

using Grpc.Net.Client;
using Servic1;
using System.Globalization;


var chanel = GrpcChannel.ForAddress("http://localhost:5220");
var greetClient = new Greeter.GreeterClient(chanel);

var respons = greetClient.SayHello(new HelloRequest { Name = Console.ReadLine() });

await Task.Run(async () =>
{
    while (await respons.ResponseStream.MoveNext(new CancellationToken()))
    {
        await Console.Out.WriteLineAsync(respons.ResponseStream.Current.Message);
    }
});