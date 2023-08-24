using MassTransit;
using Microsoft.EntityFrameworkCore;
using Order.Api.Models;
using Shared.Events;

namespace Order.Api.Consumer;

public class StockNotReservedEventConsumer : IConsumer<StockNotReservedEvent>
{
    readonly OrderApiDbContext orderApiContext;

    public StockNotReservedEventConsumer(OrderApiDbContext orderApiContext)
    {
        this.orderApiContext = orderApiContext;
    }
    public async Task Consume(ConsumeContext<StockNotReservedEvent> context)
    {
        var order = await orderApiContext.Orders.FirstOrDefaultAsync(o => o.OrderId == context.Message.OrderId);
        order.OrderStatu = Models.Enums.OrderStatus.Failed;
        await orderApiContext.SaveChangesAsync();
    }
}
