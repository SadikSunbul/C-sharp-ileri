




using globalCRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;


TetstContext context = new();


curudıslemelrıglobal ıslem = new();

Anne anne = new() {
 Adi="Ayse",
  Soyadi="Yılmaz",
   Çocuklar=new HashSet<Çocuk>()
   {
       new Çocuk()
       {
            Adi="taha",
             Soyadı="yılmaz"
       },
       new Çocuk()
       {
            Adi="ahmet",
             Soyadı="yılmaz"
       },
       new Çocuk()
       {
            Adi="ali",
             Soyadı="yılmaz"
       }
   }
};

Araba araba = new() { Plaka = "42 aa 42" };

ıslem.VeriEkle(anne, context);
ıslem.VeriGüncelle(araba, context);

Console.WriteLine("Tamam");
Console.ReadLine();
public class Anne
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public ICollection<Çocuk> Çocuklar { get; set; }
}

public class Çocuk
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Soyadı { get; set; }
    public Anne Anne { get; set; }
}

public class Araba
{
    public int Id { get; set; }
    public string Plaka { get; set; }

}
public class TetstContext:DbContext
{
    public DbSet<Anne> Anneler { get; set; }
    public DbSet<Çocuk> Çocuklar { get; set; }
    public DbSet<Araba> Arabalar { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=CURDislemleriglobal;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()) ;


    }
}

public class AnneConigrations : IEntityTypeConfiguration<Anne>
{
    public void Configure(EntityTypeBuilder<Anne> builder)
    {
        builder.HasMany(i => i.Çocuklar)
            .WithOne(i => i.Anne);
    }
}