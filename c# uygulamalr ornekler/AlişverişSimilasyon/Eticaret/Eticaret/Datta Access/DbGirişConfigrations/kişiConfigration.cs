using Eticaret.Datta_Access.DbGirişEntitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbGirişConfigrations
{
    public class kişiConfigration : IEntityTypeConfiguration<Kişi>
    {
        public void Configure(EntityTypeBuilder<Kişi> builder)
        {
            builder.UseTpcMappingStrategy();

            builder.Property<DateTime>("Kayıt Zamanı")
                .HasDefaultValueSql("GETDATE()");
        }
      }
}
