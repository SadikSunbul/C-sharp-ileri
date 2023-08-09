using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Domain.Entities;
using System.Net;

namespace Proje.Persistence.EntityConfiguration;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b => b.CreateDate).HasColumnName("CreatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name, name: "Uk_Brands_Name").IsUnique(); //isime göre bir indexleme yaptı isimler farklı olmalıdır dedi

        builder.HasMany(b => b.Models); //birsürü modele sahip olabilir
        
        //global filtere
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); //deleted ın valuesı yok ıse null olanları getır dedık 
    }
}
