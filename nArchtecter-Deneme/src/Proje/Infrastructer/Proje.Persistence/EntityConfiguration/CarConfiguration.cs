using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistence.EntityConfiguration;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    //arabayı confıgre ettıgımız yer
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(b => b.Id);

        builder.Property(b => b.Id).IsRequired();
        builder.Property(b => b.Model).IsRequired();
        builder.Property(b => b.Marka).IsRequired();
        builder.Property(b => b.CreateDate).IsRequired();


        //global fltre
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
    }
}
