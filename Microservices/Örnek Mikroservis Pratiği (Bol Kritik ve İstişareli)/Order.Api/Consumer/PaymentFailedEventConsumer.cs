using MassTransit;
using Microsoft.EntityFrameworkCore;
using Order.Api.Models;
using Shared.Events;
using System.Runtime.CompilerServices;

namespace Order.Api.Consumer;

public class PaymentFailedEventConsumer : IConsumer<PaymendFailtEvent>
{
    readonly OrderApiDbContext orderApiContext;

    public PaymentFailedEventConsumer(OrderApiDbContext orderApiContext)
    {
        this.orderApiContext = orderApiContext;
    }
    public async Task Consume(ConsumeContext<PaymendFailtEvent> context)
    {
        var order = await orderApiContext.Orders.FirstOrDefaultAsync(o => o.OrderId == context.Message.OrderId);
        order.OrderStatu = Models.Enums.OrderStatus.Failed;
        await orderApiContext.SaveChangesAsync();
    }
}
