using MassTransit;
using Shared.Events;

namespace Payment.Api.Consumers;

public class StockReservedEventConsumer : IConsumer<StockReservedEvent>
{
    private readonly IPublishEndpoint publishEndpoint;

    public StockReservedEventConsumer(IPublishEndpoint publishEndpoint)
    {
        this.publishEndpoint = publishEndpoint;
    }

    public Task Consume(ConsumeContext<StockReservedEvent> context)
    {
        //ödeme işlemleri
        if (true)
        {
            //ödeme başarıl ile tamamlandığını ...
            PaymentCompletedEvent payment = new()
            {
                OrderId = context.Message.OrderId
            };
            publishEndpoint.Publish(payment);
            Console.WriteLine("Ödeme bvaşarılı");
        }
        else
        {
            //ödeme sıkıntılı oldu ... 
            PaymendFailtEvent paymendFailtEvent = new()
            {
                OrderId = context.Message.OrderId,
                Message = "Bakıye yetersiz"
            };
            publishEndpoint.Publish(paymendFailtEvent);
            Console.WriteLine("Ödeme başarısız");
        }

        return Task.CompletedTask;
    }
}
