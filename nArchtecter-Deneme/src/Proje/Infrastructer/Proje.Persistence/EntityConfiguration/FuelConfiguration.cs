using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Domain.Entities;

namespace Proje.Persistence.EntityConfiguration;

public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
{
    public void Configure(EntityTypeBuilder<Fuel> builder)
    {
        builder.ToTable("Fuels").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b => b.CreateDate).HasColumnName("CreatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name, name: "Uk_Fuels_Name").IsUnique(); //isime göre bir indexleme yaptı isimler farklı olmalıdır dedi ve uniq olucak 

        builder.HasMany(b => b.Models); //birsürü modele sahip olabilir

        //global filtere
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); //deleted ın valuesı yok ıse null olanları getır dedık 
    }
}