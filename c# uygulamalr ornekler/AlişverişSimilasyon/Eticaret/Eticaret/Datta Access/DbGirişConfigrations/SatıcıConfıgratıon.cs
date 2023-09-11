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
    public class SatıcıConfıgratıon : IEntityTypeConfiguration<Satıcı>
    {
        public void Configure(EntityTypeBuilder<Satıcı> builder)
        {
            builder.HasMany(i => i.ürünler)
                 .WithOne(i => i.satıcı);
        }
    }
}
