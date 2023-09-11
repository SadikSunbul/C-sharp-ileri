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
    public class SepetConfigration : IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
            builder.HasKey(i => new { i.ÜrünId, i.KullanıcıId });

            builder.HasOne(i => i.ürün)
                .WithMany(i => i.sepetkullanıcılar);

            builder.HasOne(i => i.NkKullanıcı)
                .WithMany(i => i.Sepetürünler);

        }
    }
}
