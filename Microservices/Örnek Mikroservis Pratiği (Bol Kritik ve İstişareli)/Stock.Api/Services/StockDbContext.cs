using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Stock.Api.Services;

public class StockDbContext : DbContext
{
    public StockDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Stock.Api.Models.Entities.Stock> Stocks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
