using GirişSimilasyonu.BusinessLayer.Entityler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GirişSimilasyonu.BusinessLayer.DataBağlantısı
{
    public class ProjeContext:DbContext
    {
        public DbSet<Çalışan>  Çalışanlar { get; set; }
        public DbSet<Kişi> Kişiler { get; set; }
        public DbSet<NormalKullanıcılar> NormalKullanıcılars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.HasSequence("EC_Sequence_calısan") 
            .StartsAt(100)   
            .IncrementsBy(1);
            modelBuilder.HasSequence("EC_Sequence_kullanıcı")
            .StartsAt(1000)
            .IncrementsBy(1);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
