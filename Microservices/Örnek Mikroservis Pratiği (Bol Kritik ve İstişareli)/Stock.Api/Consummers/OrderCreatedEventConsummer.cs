using MassTransit;
using Microsoft.EntityFrameworkCore;
using Shared.Events;
using Stock.Api.Services;

namespace Stock.Api.Consummers;

public class OrderCreatedEventConsummer : IConsumer<OrderCreatedEvent> //yayınlanma olursa yakala  
{//burayı calıstır ilgili işleri buradan yap 
    private readonly StockDbContext stockcontext;

    public OrderCreatedEventConsummer(StockDbContext context)
    {
        stockcontext = context;
    }

    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        //Console.WriteLine(context.Message.OrderId + " - " + context.Message.BuyerId);

        List<bool> stockResult = new();
        foreach (var item in context.Message.OrderItem)
        {
            var data = await stockcontext.Stocks.FirstOrDefaultAsync(i => i.ProductId == item.ProductId && i.Count >= item.Count);
            if (data != null)
                stockResult.Add(false);
            else
                stockResult.Add(true);
        }
        if (stockResult.TrueForAll(sr => sr.Equals(true)))
        {
            //tutarlı gereklı sıparıs ıslemlerı yapılıcak 
            foreach (var item in context.Message.OrderItem)
            {
                var stock = stockcontext.Stocks.FirstOrDefault(i => i.ProductId == item.ProductId);
                stock.Count = stock.Count - item.Count;
                await stockcontext.SaveChangesAsync();
            }
            //Payment .... stok ıslemelrın tamamlandıgına dair bir event olusturup paymenta yayınlıycaz 
        }
        else
        {
            //sipariş tutarsız mesela stoc adedinden daha fazla sipariş vermiş olabilir
        }

        return;
    }
}
