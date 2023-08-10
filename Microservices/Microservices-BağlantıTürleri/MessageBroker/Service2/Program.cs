
//Consumer

//using RabbitMQ.Client;
//using RabbitMQ.Client.Events;
//using System.Text;
//using System.Xml.Linq;

//ConnectionFactory factory = new();

//factory.Uri = new("amqps://xomvilok:bzp8Z98qipQkPmCF5a26xxwwoE1ejUOh@chimpanzee.rmq.cloudamqp.com/xomvilok");

//using IConnection connection = factory.CreateConnection();
//using IModel chanel = connection.CreateModel();

//chanel.ExchangeDeclare(exchange: "direct-exchande-example", type: ExchangeType.Direct);

//string queueName = chanel.QueueDeclare().QueueName;

//chanel.QueueBind(
//    queueName,
//    exchange: "direct-exchande-example",
//    routingKey: "direct-queue-example");

//EventingBasicConsumer conusumer = new(chanel);

//chanel.BasicConsume(
//    queue:queueName,
//     autoAck:true,
//     consumer:conusumer
//    );

//conusumer.Received += (send, e) =>
//{
//    string message = Encoding.UTF8.GetString(e.Body.Span);
//    Console.WriteLine(message);
//};

//Console.ReadLine();

using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://xomvilok:bzp8Z98qipQkPmCF5a26xxwwoE1ejUOh@chimpanzee.rmq.cloudamqp.com/xomvilok");
using IConnection connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "hello",
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);

    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (model, ea) =>
    {
        var body = ea.Body.Span;
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine(" [x] Received {0}", message);
    };
    channel.BasicConsume(queue: "hello",
                         autoAck: true,
                         consumer: consumer);

    Console.WriteLine(" Press [enter] to exit.");
    Console.ReadLine();
