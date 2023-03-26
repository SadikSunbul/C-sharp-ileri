


using Microsoft.EntityFrameworkCore;

ApplicationDbContext context = new();


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