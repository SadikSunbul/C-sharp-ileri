using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Configration
{
    public class LikeConfigration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            
            builder.HasKey(i=>new {i.FoodId,i.CustomerId});

            builder.HasOne(i => i.Customer)
                .WithMany(i => i.foods)
                .HasForeignKey(i => i.CustomerId);

            builder.HasOne(i => i.Food)
                .WithMany(i => i.Customers)
                .HasForeignKey(i => i.FoodId);
        }
    }
}
