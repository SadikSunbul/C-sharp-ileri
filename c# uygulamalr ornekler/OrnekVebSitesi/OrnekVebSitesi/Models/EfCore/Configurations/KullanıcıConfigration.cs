using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrnekVebSitesi.Models.EfCore.Entities;

namespace OrnekVebSitesi.Models.EfCore.Configurations
{
    public class KullanıcıConfigration : IEntityTypeConfiguration<Kullanıcı>
    {
        public void Configure(EntityTypeBuilder<Kullanıcı> builder)
        {
            builder.Property(i => i.Email)
                .IsRequired(); //boş geilemez

            builder.HasIndex(i => i.Email).IsUnique(); //benzersiz olucak dedik

            builder.HasCheckConstraint("CHK_Email", "Email LIKE '%_@__%.__%'"); 
            //burada gırılen epostanın turunu belırledık ıcerısınde 1 tane @ ve 1 tane . olanı bul dedik
            /*
             Bu kod, bir veritabanı tablosunda "Eposta" adlı bir sütun için bir kısıtlama (constraint) tanımlar. Bu kısıtlama, "CHK_Eposta" adı altında kaydedilir ve Eposta sütunundaki değerlerin belirtilen desene uygun olmasını sağlar.

Desen, "%@%.%" şeklindedir. Burada "" belirli bir karakteri ifade ederken, "@" sembolü yazılması gerektiğini belirtir. "" iki adet "_" kullanımı ile iki yer tutucu karakter olduğunu belirtir. Sonrasında tekrar "." karakteri gelmesi gerektiğini ve sonrasında belirli bir uzantının yazılması gerektiğini belirten "%.%" kullanımı vardır.

Bu kısıtlama sonucu, Eposta sütununa kaydedilen değerler, "@" sembolünün iki "_" karakteri arasında olması, ardından en az bir nokta işareti içermesi ve sonrasında belirli bir uzantıya sahip olması gerektiği kontrol edilerek kaydedilir.
             */

            builder.Property(i => i.Şifre)
                    .IsRequired();

            builder.HasIndex(i => new { i.Email, i.Şifre });

        }
    }
    

}
