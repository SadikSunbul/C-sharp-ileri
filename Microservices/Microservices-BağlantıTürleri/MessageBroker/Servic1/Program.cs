
//Publisher

//using RabbitMQ.Client;
//using System.Text;

//ConnectionFactory factory = new();

//factory.Uri = new("amqps://xomvilok:bzp8Z98qipQkPmCF5a26xxwwoE1ejUOh@chimpanzee.rmq.cloudamqp.com/xomvilok");

//using IConnection connection = factory.CreateConnection();
//using IModel chanel = connection.CreateModel();

//chanel.ExchangeDeclare(exchange: "direct-exchande-example", type: ExchangeType.Direct);

//while (true)
//{
//    Console.Write("Mesaj :");
//    string message = Console.ReadLine();
//    byte[] byteMessage = Encoding.UTF8.GetBytes(message);

//    chanel.BasicPublish(
//        exchange: "direct-exchande-example",
//         routingKey: "direct-queue-example",
//         body: byteMessage
//        );
//}

//Console.ReadLine();




using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new ConnectionFactory() ;
factory.Uri = new("amqps://xomvilok:bzp8Z98qipQkPmCF5a26xxwwoE1ejUOh@chimpanzee.rmq.cloudamqp.com/xomvilok");
using IConnection connection = factory.CreateConnection();
using var channel = connection.CreateModel();

    channel.QueueDeclare(queue: "hello",
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);

while (true)
{
    Console.Write("Mesaj : ");
    string message = Console.ReadLine();
    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(exchange: "",
                         routingKey: "hello",
                         basicProperties: null,
                         body: body);

}


Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();


#region Durable
/*
 RabbitMQ'da kuyruk oluştururken durable parametresi, kuyruğun dayanıklılığını belirler. durable parametresi, kuyruğun fiziksel olarak kalıcı olup olmadığını kontrol eder. Yani, eğer durable değeri true olarak ayarlanırsa, kuyruk fiziksel olarak diskte saklanır ve RabbitMQ sunucusu yeniden başlatılsa bile kuyruk ve içerdiği mesajlar korunur. Eğer false olarak ayarlanırsa, kuyruk yalnızca hafızada tutulur ve RabbitMQ sunucusu yeniden başlatıldığında kuyruk ve mesajlar kaybolabilir.
 */
#endregion

#region Exclusive
/*
 * RabbitMQ'da exclusive parametresi, bir kuyruğun sadece belirli bir bağlantı tarafından kullanılabilir olup olmadığını belirler. Bu parametre, bağlantıya özgü bir kuyruk oluşturulup oluşturulmayacağını kontrol eder.

Eğer bir kuyruğun exclusive değeri true olarak ayarlanırsa, o kuyruk sadece kuyruğu oluşturan bağlantı tarafından kullanılabilir. Bu kuyruğa başka bir bağlantı erişemeyecektir. Bu genellikle geçici veya geçici bir amaç için kullanılır. Örneğin, bir tüketici kuyruğu sadece belirli bir bağlantı tarafından kullanılmak üzere oluşturulabilir ve bağlantı kapandığında bu kuyruk otomatik olarak silinir.
 */
#endregion

#region autoDelete
/*
 RabbitMQ'da autoDelete parametresi, bir kuyruğun son tüketici bağlantısı kapandığında otomatik olarak silinip silinmeyeceğini belirler. Yani, bir kuyruk üzerindeki tüm tüketici bağlantıları kapandığında ve kuyrukta mesaj kalmadığında, autoDelete parametresi true olarak ayarlanmışsa, kuyruk otomatik olarak silinir.

Bu özellik genellikle geçici ve dinamik olarak oluşturulan kuyruklar için kullanılır. Örneğin, bir tüketici bağlantısı kuyruğa bağlandığında ve tüketici işini tamamladığında, bağlantı kapatıldığında ve tüketici olmadığında kuyruk da otomatik olarak silinir. Bu, gereksiz kuyrukların ve kaynakların zaman içinde birikmesini engellemeye yardımcı olur.

Eğer autoDelete parametresi false olarak ayarlanırsa, kuyruk otomatik olarak silinmez ve elle silinmesi gerekmektedir.

Özetle, autoDelete parametresi, tüketici bağlantıları kapandığında kuyruğun otomatik olarak silinip silinmeyeceğini belirler. Bu özellik dinamik olarak kullanılan geçici kuyruklar için oldukça yararlıdır.
 */

#endregion