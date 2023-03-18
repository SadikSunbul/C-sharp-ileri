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
    public class ÇalışanConfigrations : IEntityTypeConfiguration<Çalışan>
    {
        public void Configure(EntityTypeBuilder<Çalışan> builder)
        {
            builder
                .HasData(
                new Çalışan()
                {
                    Id=99999,
                     İsim="ahmet",
                     Soyisim="kılıç",
                     Email="ahmet.kılıç@gmail.com",
                     Şifre="test2",
                     ÇalışanKonumu="Normal çalışan",
                     ÇalışanNo=1 
                },
                new Çalışan()
                {
                    Id = 99998,
                    İsim = "osman",
                    Soyisim = "yılmaz",
                    Email = "osman.yılmaz@gmail.com",
                    Şifre = "test3",
                    ÇalışanKonumu = "Yönetici",
                    ÇalışanNo = 2
                }
                );
            builder.Property(i=>i.ÇalışanNo)
                .HasDefaultValueSql("NEXT VALUE FOR EC_Sequence_calısan");
            //her kayıtta burada kendısı bır calısan no atıycak ama bu calısn ları calısanlar  kaydede bılıcek 
        }
    }
}
