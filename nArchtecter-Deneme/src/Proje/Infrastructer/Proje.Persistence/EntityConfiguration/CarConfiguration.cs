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

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.ModelId).HasColumnName("ModelId").IsRequired();
        builder.Property(b => b.Kilometer).HasColumnName("Kilometer");
        builder.Property(b => b.CarState).HasColumnName("State");
        builder.Property(b => b.ModelYear).HasColumnName("ModelYear");



        builder.HasOne(b => b.Model);

        //global filtere
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); //deleted ın valuesı yok ıse null olanları getır dedık 
    }
}
