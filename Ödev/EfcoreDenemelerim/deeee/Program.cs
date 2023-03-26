


using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

ApplicationDbContext context = new();

//Employee emp = new() { Name = "SAdık", Surname = "Sunbul" };
//Employee emp1 = new() { Name = "Ali", Surname = "Sunbul" };
//Employee emp2 = new() { Name = "Taha", Surname = "Hamıdıoglu" };
//Employee emp3 = new() { Name = "Safa", Surname = "Yardan" };
//await context.Employees.AddRangeAsync(emp,emp1,emp2,emp3);

var data = await context.Employees.FirstOrDefaultAsync(i => i.Id == 1);

data.Name = "Fatıma";

await context.SaveChangesAsync();   
Console.WriteLine("Tamm");
Console.ReadLine();
class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
}
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Employee> Employees { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().ToTable("Employees", builder => builder.IsTemporal());//temple table olucak dedık 
        modelBuilder.Entity<Person>().ToTable("Persons", builder => builder.IsTemporal());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=Denemeler;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
    }
}