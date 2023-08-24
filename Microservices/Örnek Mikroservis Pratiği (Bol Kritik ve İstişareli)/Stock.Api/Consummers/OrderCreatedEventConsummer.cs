using MassTransit;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Events;
using Stock.Api.Services;

namespace Stock.Api.Consummers;

public class OrderCreatedEventConsummer : IConsumer<OrderCreatedEvent> //yayınlanma olursa yakala  
{//burayı calıstır ilgili işleri buradan yap 
    private readonly StockDbContext stockcontext;
    private readonly ISendEndpointProvider sendEndpointProvider;
    private readonly IPublishEndpoint publishEndpoint;
    public OrderCreatedEventConsummer(StockDbContext context, ISendEndpointProvider sendEndpointProvider, IPublishEndpoint publishEndpoint)
    {
        stockcontext = context;
        this.sendEndpointProvider = sendEndpointProvider;
        this.publishEndpoint = publishEndpoint;
    }

    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        //Console.WriteLine(context.Message.OrderId + " - " + context.Message.BuyerId);

        List<bool> stockResult = new();
        foreach (var item in context.Message.OrderItem)
        {
            stockResult.Add(await stockcontext.Stocks.AnyAsync(i => i.ProductId == item.ProductId && i.Count >= item.Count));
        }
        if (stockResult.TrueForAll(sr => sr.Equals(true)))
        {
            //tutarlı gereklı sıparıs ıslemlerı yapılıcak 
            foreach (var item in context.Message.OrderItem)
            {
                var stock = await stockcontext.Stocks.FirstOrDefaultAsync(i => i.ProductId == item.ProductId);
                stock.Count = stock.Count - item.Count;
                await stockcontext.SaveChangesAsync();
            }
            //Payment .... stok ıslemelrın tamamlandıgına dair bir event olusturup paymenta yayınlıycaz 
            StockReservedEvent stockReserved = new()
            {
                BuyerId = context.Message.BuyerId,
                OrderId = context.Message.OrderId,
                TotalPrice = context.Message.TotalPrice
            };

            ISendEndpoint sendEndpoint = await sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{RabbitMqSettings.Payment_StockReservedEventQueue}"));//bu kuyruga göndericektir veriyi

            await sendEndpoint.Send(stockReserved);//bunu yayınladık 
            await Console.Out.WriteLineAsync("Stok işlemleri başarılı");
        }
        else
        {
            //sipariş tutarsız mesela stoc adedinden daha fazla sipariş vermiş olabilir
            StockNotReservedEvent stockNotReservedEvent = new()
            {
                BuyerId = context.Message.BuyerId,
                OrderId = context.Message.OrderId,
                Message = "... bazı ürünlerin stokta yok"
            };

            await publishEndpoint.Publish(stockNotReservedEvent);
            await Console.Out.WriteLineAsync("Stok işlemleri başarısız");

        }

        return;
    }
}
