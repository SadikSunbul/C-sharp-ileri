
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;


ApplicationDbContext context = new();

//var data = await context.PersonOrderss.ToListAsync();

//var data1=await context.DenemeViewvis.ToListAsync();

//data1[0].Name = "aaaaaaaaaa";
//context.SaveChanges();

var data=await context.Database.ExecuteSqlAsync($@"EXEC yeniProsedur 1");



Console.WriteLine("Tamam");
Console.ReadLine();
public class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }

    public ICollection<Order> Orders { get; set; }
}
public class Order
{
    public int OrderId { get; set; }
    public int PersonId { get; set; }
    public string Description { get; set; }

    public Person Person { get; set; }
}

class PersonOrders
{
    public string Name { get; set; }
    public int Count { get; set; }
}

class DenemeViewvi
{
    public string Name { get; set; }
  
    public string Description { get; set; }
}

[NotMapped]
class Storeproceder
{
    public string Name { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PersonOrders> PersonOrderss { get; set; }
    public DbSet<DenemeViewvi> DenemeViewvis { get; set; }
    public DbSet<Storeproceder> Storeproceders { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Storeproceder>()
            .HasNoKey();
        modelBuilder.Entity<Person>()
            .HasMany(i => i.Orders)
            .WithOne(i => i.Person)
            .HasForeignKey(i => i.PersonId);
        modelBuilder.Entity<PersonOrders>()
            .ToView("vm_PersonOrder")
            .HasNoKey();
        modelBuilder.Entity<DenemeViewvi>()
            .ToView("vm_Deneme");
        modelBuilder.Entity<DenemeViewvi>()
            .HasNoKey();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=Denemeler;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
    }
}


