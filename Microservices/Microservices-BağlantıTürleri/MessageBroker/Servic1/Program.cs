
//Publisher

using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new();

factory.Uri = new("amqps://xomvilok:bzp8Z98qipQkPmCF5a26xxwwoE1ejUOh@chimpanzee.rmq.cloudamqp.com/xomvilok");

using IConnection connection = factory.CreateConnection();
using IModel chanel = connection.CreateModel();

chanel.ExchangeDeclare(exchange: "direct-exchande-example", type: ExchangeType.Direct);

while (true)
{
    Console.Write("Mesaj :");
    string message = Console.ReadLine();
    byte[] byteMessage = Encoding.UTF8.GetBytes(message);

    chanel.BasicPublish(
        exchange: "direct-exchande-example",
         routingKey: "direct-queue-example",
         body: byteMessage
        );
}

Console.ReadLine();