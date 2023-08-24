using Microsoft.EntityFrameworkCore;
using Stock.Api.Models.Entities;

namespace Stock.Api.Models.EFcOREConfiguration;

public class StockConfiguation : IEntityTypeConfiguration<Stock.Api.Models.Entities.Stock>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Stock.Api.Models.Entities.Stock> builder)
    {
        builder.HasData(
            new Entities.Stock()
            {
                Count = 200,
                ProductId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
            },
            new Entities.Stock()
            {
                Count = 123,
                ProductId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
            },
            new Entities.Stock()
            {
                Count = 13,
                ProductId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
            },
            new Entities.Stock()
            {
                Count = 5,
                ProductId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
            },
            new Entities.Stock()
            {
                Count = 77,
                ProductId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
            }
            );
    }
}
