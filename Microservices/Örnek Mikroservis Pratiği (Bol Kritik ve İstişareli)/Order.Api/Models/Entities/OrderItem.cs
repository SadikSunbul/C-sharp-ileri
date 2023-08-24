namespace Order.Api.Models.Entities;


public class OrderItem
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; } //mış gibi yapıcaz değilse silsile şeklinde tüm projeyi yapmamız gerekir 
    public int Count { get; set; }
    public decimal Price { get; set; }
    public Order Order { get; set; } //ilişkisağladık
}
