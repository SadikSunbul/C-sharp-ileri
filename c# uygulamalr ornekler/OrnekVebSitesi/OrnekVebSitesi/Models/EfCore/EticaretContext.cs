using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using OrnekVebSitesi.Models.EfCore.Entities;
using System.Reflection;

namespace OrnekVebSitesi.Models.EfCore
{
    public class EticaretContext:DbContext
    {
        #region Dbset
        public DbSet<Kullanıcı> Kullanıcılar { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Eticaret;User Id=SA ; Password=Viabelli34*.;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
