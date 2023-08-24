using MassTransit;
using Microsoft.EntityFrameworkCore;
using Order.Api.Models;
using Order.Api.Models.Entities;
using Shared.Events;

namespace Order.Api.Consumer;

public class PaymentCompletedEventConsumer : IConsumer<PaymentCompletedEvent>
{
    readonly OrderApiDbContext orderApiContext;

    public PaymentCompletedEventConsumer(OrderApiDbContext orderApiContext)
    {
        this.orderApiContext = orderApiContext;
    }

    public async Task Consume(ConsumeContext<PaymentCompletedEvent> context)
    {
        var order = await orderApiContext.Orders.FirstOrDefaultAsync(o => o.OrderId == context.Message.OrderId);
        order.OrderStatu = Models.Enums.OrderStatus.Completed;
        await orderApiContext.SaveChangesAsync();
    }
}
