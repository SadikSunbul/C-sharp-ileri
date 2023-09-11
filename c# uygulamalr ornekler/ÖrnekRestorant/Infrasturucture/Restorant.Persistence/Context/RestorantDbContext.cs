using Microsoft.EntityFrameworkCore;
using Restorant.Domain.Entiteis;
using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Context
{
	public class RestorantDbContext : DbContext
	{
		public RestorantDbContext(DbContextOptions options) : base(options)
		{ }

		#region DbSet
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Table> Tables { get; set; }
		public DbSet<Worker> Workers { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Basket> Baskets { get; set; }
		public DbSet<Like> Likes { get; set; }
		public DbSet<Payment> Payments { get; set; }

		#endregion
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var datas = ChangeTracker.Entries<BaseEntity>(); //base entıty uzerınde kılerı yakala degısıklık olanları 

			foreach (var data in datas) //degısıklıklerı donduk burada 
			{
				var _ = data.State switch
				{
					EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,  //yapılan ıslem ekleme ıslemı ıse burası calıscak 
					EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow, //ypılan ıslem guncelleme ıse bursı calısır 
					_ => default // Diğer durumlar için hiçbir şey yapma  {} bu calısmaz c# 9 dan dusuk duan bu program o yuzden default dedik
				}; ;

			}


			return await base.SaveChangesAsync(cancellationToken);
		}

	}
}
