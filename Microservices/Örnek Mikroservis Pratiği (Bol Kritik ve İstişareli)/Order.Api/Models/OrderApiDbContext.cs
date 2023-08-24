using Microsoft.EntityFrameworkCore;
using Order.Api.Models.Entities;

namespace Order.Api.Models;

public class OrderApiDbContext : DbContext
{
    public OrderApiDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Order.Api.Models.Entities.Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

}
