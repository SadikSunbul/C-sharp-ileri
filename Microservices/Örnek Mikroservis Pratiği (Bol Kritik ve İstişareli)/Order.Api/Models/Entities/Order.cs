using Order.Api.Models.Enums;
using System.Net.NetworkInformation;

namespace Order.Api.Models.Entities;

public class Order
{
    public Guid OrderId { get; set; }
    public Guid BuyerId { get; set; }
    public Decimal TotalPrice { get; set; }
    public OrderStatus OrderStatu { get; set; }
    public DateTime CreateDate { get; set; }

    public ICollection<OrderItem> OrderItems { get; set;}
}
