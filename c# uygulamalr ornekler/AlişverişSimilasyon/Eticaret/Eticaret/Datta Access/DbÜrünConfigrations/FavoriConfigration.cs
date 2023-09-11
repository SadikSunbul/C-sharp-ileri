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
    public class FavoriConfigration : IEntityTypeConfiguration<Favori>
    {
        public void Configure(EntityTypeBuilder<Favori> builder)
        {
            builder.HasKey(i=>new {i.ürünId,i.kullanıcıId});

            builder.HasOne(i=>i.NkKullanıcı)
                .WithMany(i=>i.favoriürünler);

            builder.HasOne(i => i.ürün)
                .WithMany(i => i.Fvorikullanıcılar);
        }
    }
}
