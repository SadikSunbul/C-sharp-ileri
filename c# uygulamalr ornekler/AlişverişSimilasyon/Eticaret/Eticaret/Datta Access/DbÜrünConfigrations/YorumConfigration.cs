using Eticaret.Datta_Access.DbÜrünEntitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbÜrünConfigrations
{
    public class YorumConfigration : IEntityTypeConfiguration<Yorum>
    {
        public void Configure(EntityTypeBuilder<Yorum> builder)
        {
            builder.HasOne(i => i.Ürün)
                .WithMany(i => i.Yorumlar);

            builder.Property(i => i.YorumAtılmaZamanı)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
