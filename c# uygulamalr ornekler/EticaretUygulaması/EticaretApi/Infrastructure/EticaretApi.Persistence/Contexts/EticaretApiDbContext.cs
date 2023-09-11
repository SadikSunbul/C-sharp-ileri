using EticaretApi.Domain.Entities;
using EticaretApi.Domain.Entities._File;
using EticaretApi.Domain.Entities._Identity;
using EticaretApi.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence.Contexts
{
    public class EticaretApiDbContext : IdentityDbContext<AppUser,AppRole,string>
    {

        public EticaretApiDbContext(DbContextOptions options) : base(options)
        { } //Bu kontainer IoC de doldurulucak koymazsak hata alırız 
        //ServiceRegistration olustur ust için 
        //DesingTimeDbContextFctory buradaki de .net cl ıcın olusturmamız gerekn sınıf

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        #region TPH
        public DbSet<Domain.Entities._File.File> files { get; set; }
        public DbSet<InvoiceFile> InvoiceFiles { get; set; }
        public DbSet<ProductImageFile> ProductImageFiles { get; set; }
        #endregion
        //burası ne zamna tetıklenır bız nezaman savechangesAsync methodunu tetıklers ısek ozaman burası kayıttan once cecalısır ıslemler den sonrada en altta kaydeder
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)//soguda araya gırmemıze yarar //hangisini kullandıysak onu overıde etmelıyız
        {
            //ChangeTracker :Entityler uzerınden yapılan degısıklıklerı yada yenı eklenen verılerın yakalanmasını saglıyan propertydir .update operasyonşarında Track edılen verılerı yakalayıp elde etmemızı saglar.
            var datas = ChangeTracker.Entries<BaseEntity>(); //base entıty uzerınde kılerı yakala degısıklık olanları 

            foreach (var data in datas) //degısıklıklerı donduk burada 
            {
                var _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate=DateTime.UtcNow,  //yapılan ıslem ekleme ıslemı ıse burası calıscak 
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow, //ypılan ıslem guncelleme ıse bursı calısır 
                    _ => default // Diğer durumlar için hiçbir şey yapma  {} bu calısmaz c# 9 dan dusuk duan bu program o yuzden default dedik
                };;
                
            }


            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
