using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Domain.Entities;

namespace Proje.Persistence.EntityConfiguration;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.BrandId).HasColumnName("BrandId").IsRequired();
        builder.Property(b => b.FuelId).HasColumnName("FuelId").IsRequired();
        builder.Property(b => b.TransmissonId).HasColumnName("TransmissonId").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();

        builder.Property(b => b.DailyPrice).HasColumnName("DailyPrice").IsRequired();
        builder.Property(b => b.ImageUrl).HasColumnName("ImageUrl");


        builder.Property(b => b.CreateDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdateDate).HasColumnName("UpdateDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name, name: "Uk_Models_Name").IsUnique(); //isime göre bir indexleme yaptı isimler farklı olmalıdır dedi ve uniq olucak 

        builder.HasOne(b => b.Brand); //bir modelin 1 markası olur
        builder.HasOne(b => b.Fuel);
        builder.HasOne(b => b.Transmission);
        builder.HasMany(b => b.Cars);

        //global filtere
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); //deleted ın valuesı yok ıse null olanları getır dedık 
    }
}