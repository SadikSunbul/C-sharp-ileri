using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Api.Models;
using Order.Api.Models.Entities;
using Order.Api.Models.Enums;
using Order.Api.ViewModels;
using Shared.Events;

namespace Order.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly OrderApiDbContext context;
    private readonly IPublishEndpoint _publishEndpoint;
    public OrdersController(OrderApiDbContext context, IPublishEndpoint publishEndpoint)
    {
        this.context = context;
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(CreateOrderViewModel createOrder)
    {
        //Normalde buranın böyle olmaması gerekiyor bunlara takılmamak lazım burada microservice ögreniyoruz
        Order.Api.Models.Entities.Order order = new()
        {
            OrderId = Guid.NewGuid(),
            BuyerId = createOrder.BuyerId,
            CreateDate = DateTime.UtcNow,
            OrderStatu = OrderStatus.Suspend
        };
        order.OrderItems = createOrder.OrderItems.Select(oi => new OrderItem
        {
            Count = oi.Count,
            Price = oi.Price,
            ProductId = oi.ProductId
        }).ToList();
        order.TotalPrice = createOrder.OrderItems.Sum(i => (i.Price * i.Count));
        await context.Orders.AddAsync(order);
        await context.SaveChangesAsync();

        OrderCreatedEvent orderCreatedEvent = new()
        {
            BuyerId = order.BuyerId,
            OrderId = order.OrderId,
            OrderItem = order.OrderItems.Select(i => new Shared.Messages.OrderItemMessage
            {
                Count = i.Count,
                ProductId = i.ProductId
            }).ToList(),
            TotalPrice = order.TotalPrice
        };
        await _publishEndpoint.Publish(orderCreatedEvent);
        return Ok("Ok");
    }
}
