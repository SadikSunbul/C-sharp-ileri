using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistence.Context;

public class BaseContext : DbContext
{
    protected IConfiguration configuration { get; set; }
    public BaseContext(DbContextOptions options,IConfiguration configuration) : base(options)
    {
        this.configuration= configuration;
        Database.EnsureCreated();
    }
    public DbSet<Car> Cars { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
