using Eticaret.Datta_Access.DbGirişEntitys;
using Eticaret.Datta_Access.DbÜrünEntitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access
{
    public class EticaretContext : DbContext
    {
        #region Entiys and Dbset

        public DbSet<Kişi> kİşiler { get; set; }
        public DbSet<NkKullanıcı> NkKullanıcılar { get; set; }
        public DbSet<Yönetici> Yöneticiler { get; set; }
        public DbSet<Satıcı> Satıcılar { get; set; }
        public DbSet<Favori> Favoriler { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Ürün> Ürünler { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=Eticaret;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
