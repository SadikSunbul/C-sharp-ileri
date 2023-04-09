using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

TetstContex contex = new();

Console.WriteLine("Tamam");
Console.ReadLine();



#region birebir
public class kullanıcı
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Soyadı { get; set; }
    public int HesapId { get; set; }
    public Hesap Hesap { get; set; }
}
public class Hesap
{
    public int Id { get; set; }
    public string HesapAdı { get; set; }
    public kullanıcı Kullanıcı { get; set; }

}
#endregion

#region birecok
public class Öğrenci
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Laylaylom { get; set; }
    public int sequences { get; set; }
    public string Soyadı { get; set; }
    public string _tc;
    public string Tc { get => _tc.Substring(0,4); set=>_tc=value; }
    public int SınıfNo { get; set; }
    public Sınıf Sınıf { get; set; }
}

public class Sınıf
{
    public int Id { get; set; }
    public string Sınıfno { get; set; }
    public ICollection<Öğrenci> Öğrenciler { get; set; }
}
#endregion

#region Çoka çok
public class kişi
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public ICollection<kişikurs> Kurslar { get; set; }
}
public class Kurs
{
    public int Id { get; set; }
    public string KursAdi { get; set; }
    public ICollection<kişikurs> Kişiler { get; set; }
}

public class kişikurs
{
    public int KişiId { get; set; }
    public int KursId { get; set; }
    public kişi Kişi { get; set; }
    public Kurs Kurs { get; set; }
}
#endregion

#region TPT

public class Asınıfı
{
    public int Id { get; set; }
    public string Aacıklama { get; set; }

}
public class Bsınıfı:Asınıfı
{
   
    public string Bacıklama { get; set; }

}
public class Csınıfı:Bsınıfı
{
   
    public string Cacıklama { get; set; }
}
#endregion
#region TPH
public class   Xsınıfı
{
    public int Id { get; set; }
    public string Xacıklama { get; set; }

}
public class Ysınıfı : Xsınıfı
{
    
    public string Yacıklama { get; set; }

}
public class Zsınıfı : Ysınıfı
{
    
    public string Zacıklama { get; set; }
}
#endregion
#region TPC
public class A1
{
    public int AId { get; set; }
    public string Aacıklama { get; set; }

}
public class B1 : A1
{
    
    public string Bacıklama { get; set; }

}
public class C1 : B1
{
    
    public string Cacıklama { get; set; }
}
#endregion

public class TetstContex :DbContext
{
    #region DBSETLER
    public DbSet<Öğrenci> Öğrenciler { get; set; }
    public DbSet<Sınıf> Sınıflar { get; set; }
    public DbSet<kullanıcı> Kullanıcılar { get; set; }
    public DbSet<Hesap> Hesaplar { get; set; }
    public DbSet<kişi> Kişiler { get; set; }
    public DbSet<Kurs> Kurslar { get; set; }
    public DbSet<kişikurs> Kişikurslar { get; set; }
    public DbSet<Asınıfı> Asınıfıs { get; set; }
    public DbSet<Bsınıfı> Bsınıfıs { get; set; }
    public DbSet<Csınıfı> Csınıfıs { get; set; }
    public DbSet<Xsınıfı> Xsınıfıs { get; set; }
    public DbSet<Ysınıfı> Ysınıfıs { get; set; }
    public DbSet<Zsınıfı> Zsınıfıs { get; set; }
    public DbSet<A1> A1 { get; set; }
    public DbSet<B1> B1 { get; set; }
    public DbSet<C1> C1 { get; set; }
    #endregion


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=Test;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.HasSequence("deger")
            .StartsAt(900);
    }
}

#region Configuration
public class ÖğrenciConfigration : IEntityTypeConfiguration<Öğrenci>
{
    public void Configure(EntityTypeBuilder<Öğrenci> builder)
    {
        builder.HasOne(i => i.Sınıf)
            .WithMany(i => i.Öğrenciler)
            .HasForeignKey(i => i.SınıfNo);

        builder.Property(i => i.Tc)
            .HasField(nameof(Öğrenci._tc))
            .UsePropertyAccessMode(PropertyAccessMode.Field);

        builder.Property<DateTime>("KayıtZamanı")
            .HasDefaultValue(DateTime.Now);
        builder.HasIndex(i => new { i.Adi, i.Soyadı });

        builder.Ignore(i => i.Laylaylom);

        builder.HasQueryFilter(i => i.Id > 0);

        builder.Navigation(i => i.Sınıf)
            .AutoInclude();

        builder.Property(i => i.sequences)
            .HasDefaultValueSql("NEXT VALUE FOR deger");
    }
}

public class kullanıcıConfigration : IEntityTypeConfiguration<kullanıcı>
{
    public void Configure(EntityTypeBuilder<kullanıcı> builder)
    {
        builder.HasOne(i => i.Hesap)
            .WithOne(i => i.Kullanıcı)
            .HasForeignKey<kullanıcı>(i => i.HesapId);
    }
}

public class KişiKursConfigration : IEntityTypeConfiguration<kişikurs>
{
    public void Configure(EntityTypeBuilder<kişikurs> builder)
    {
        builder.HasKey(i => new { i.KursId, i.KişiId });

        builder.HasOne(i => i.Kişi)
            .WithMany(i => i.Kurslar)
            .HasForeignKey(i => i.KişiId);

        builder.HasOne(i => i.Kurs)
            .WithMany(i => i.Kişiler)
            .HasForeignKey(i => i.KursId);


    }
}
#region TPH
public class xsınıfıConfigration : IEntityTypeConfiguration<Xsınıfı>
{
    public void Configure(EntityTypeBuilder<Xsınıfı> builder)
    {
        builder.ToTable("xsınıfı");
    }
}
public class ysınıfıConfigration : IEntityTypeConfiguration<Ysınıfı>
{
    public void Configure(EntityTypeBuilder<Ysınıfı> builder)
    {
        builder.ToTable("Ysınıfı");
    }
}
public class ZsınıfıConfigration : IEntityTypeConfiguration<Zsınıfı>
{
    public void Configure(EntityTypeBuilder<Zsınıfı> builder)
    {
        builder.ToTable("Zsınıfı");
    }
}
#endregion
#region TPC
public class A1ConfıgratıonÇ : IEntityTypeConfiguration<A1>
{
    public void Configure(EntityTypeBuilder<A1> builder)
    {
        builder.HasKey(i => i.AId);
        builder.UseTpcMappingStrategy();
    }
}
#endregion
#endregion

#region Fonksiyonlar CURUD işlemleri

public class Curud
{

    public async void Ekle<T>(T veri, TetstContex contex) where T:class
    {
        await contex.Set<T>().AddAsync(veri);
        drektSavechanges(contex);
    }

    public async void sil<T>(T veri, TetstContex contex) where T : class
    {
        contex.Set<T>().Remove(veri);
        drektSavechanges(contex);
    }

    public void güncelle<T>(T veri, TetstContex contex) where T : class
    {
        contex.Set<T>().Update(veri);
        drektSavechanges(contex);
    }

    public async void drektSavechanges(TetstContex contex) 
    {
        await contex.SaveChangesAsync();
    }
}

#endregion