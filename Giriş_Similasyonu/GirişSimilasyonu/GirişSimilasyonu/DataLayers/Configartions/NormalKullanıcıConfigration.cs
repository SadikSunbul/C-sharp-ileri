using GirişSimilasyonu.BusinessLayer.Entityler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirişSimilasyonu.BusinessLayer.Configartions
{
    public class NormalKullanıcıConfigration : IEntityTypeConfiguration<NormalKullanıcılar>
    {
        public void Configure(EntityTypeBuilder<NormalKullanıcılar> builder)
        {
            builder.Property(i=>i.KullanıcıNo)
                .HasDefaultValueSql("NEXT VALUE FOR EC_Sequence_kullanıcı");
            //her kayıt ıcın kendısı olusturcak buradakı degerı 

            builder.HasData(
                new NormalKullanıcılar()
                {
                    Id= 99997,
                     İsim="taha",
                     Soyisim="aslan",
                      Email="taha.aslan@gmail.com",
                       Şifre="test1",
                        KullanıcıNo=1,
                },
                new NormalKullanıcılar()
                {
                Id = 99996,
                     İsim = "yasin",
                     Soyisim = "susurcu",
                      Email = "yasin.susurcu@gmail.com",
                       Şifre = "test4",
                        KullanıcıNo = 2,
                }
                );

        }
    }
}
