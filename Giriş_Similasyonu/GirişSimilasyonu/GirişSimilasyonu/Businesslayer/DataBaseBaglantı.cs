using GirişSimilasyonu.BusinessLayer.DataBağlantısı;
using GirişSimilasyonu.BusinessLayer.Entityler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirişSimilasyonu.Businesslayer
{
    public  class DataBaseBaglantı
    {
       
        public static async Task KullanıcıGirişi(string email,string şifre)
        {
            ProjeContext context = new ProjeContext();
            var kontrol =await context.NormalKullanıcılars.FirstOrDefaultAsync(x => x.Email == email && x.Şifre==şifre);
            if (kontrol != null)
            {
                await Console.Out.WriteLineAsync("Kullanıcı Girişi Başarılı");
                await Console.Out.WriteLineAsync($"Hos geldınız {kontrol.İsim}-{kontrol.Soyisim}");
                
            }
            else
            {

                await Console.Out.WriteLineAsync("Kullanıcı girişi hatalı email ve şifrenizi kontrol ediniz");
            }
        
        }
        public static async void ÇalışanGirişi(string email, string şifre)
        {
            ProjeContext context = new ProjeContext();
            var kontrol = await context.Çalışanlar.FirstOrDefaultAsync(x => x.Email == email && x.Şifre == şifre);
            if (kontrol != null)
            {
                await Console.Out.WriteLineAsync("Çalışan Girişi Başarılı");
                await Console.Out.WriteLineAsync($"Hosgeldınız {kontrol.İsim}-{kontrol.Soyisim}-{kontrol.ÇalışanKonumu}");
                await Console.Out.WriteLineAsync("Çalışan eklemek isterseniz klavyeden 1 e basını,Kendi şifrenizi değitirmek için 2 ye basınız");
                int kayıt = 0;
                kayıt = int.Parse(Console.ReadLine());
                if (kayıt==1)
                {
                    await Console.Out.WriteLineAsync("Yenı bır calısan kaydı yapmak ıstedınız");
                    Çalışan calısan = new();
                    await Console.Out.WriteLineAsync("Çalısanın adını gırınız");
                    calısan.İsim = Console.ReadLine();
                    await Console.Out.WriteLineAsync("Çalısanın soyadını gırınız");
                    calısan.Soyisim = Console.ReadLine();
                    await Console.Out.WriteLineAsync("Çalısanın emailini gırınız");
                    calısan.Email = Console.ReadLine();
                    await Console.Out.WriteLineAsync("Çalısanın şifresini gırınız");
                    calısan.Şifre = Console.ReadLine();
                    await Console.Out.WriteLineAsync("Çalısanın konuunu gırınız");
                    calısan.ÇalışanKonumu = Console.ReadLine();

                    if (!string.IsNullOrEmpty(calısan.İsim) && !string.IsNullOrEmpty(calısan.Soyisim) && !string.IsNullOrEmpty(calısan.Email) && !string.IsNullOrEmpty(calısan.Şifre) && !string.IsNullOrEmpty(calısan.ÇalışanKonumu))
                    {
                        bool kontrol4 = await context.NormalKullanıcılars.AnyAsync(i => i.Email == calısan.Email);
                        if (kontrol4)
                        {
                            await Console.Out.WriteLineAsync("Bu maıl zaten var baska bır maıl atayın calısanınıza");
                        }
                        else
                        {
                            await context.Çalışanlar.AddAsync(calısan);
                            await context.SaveChangesAsync();
                            await Console.Out.WriteLineAsync("Calısan kaydedıldı");
                        }
                    }

                    
                    

                }
                else if (kayıt==2)
                {
                    await Console.Out.WriteLineAsync("Şifre değiştirmek istediniz");
                    await Console.Out.WriteLineAsync("Eski şifrenizi giriniz");
                    string şifre1 = Console.ReadLine();
                    if (şifre1== şifre)
                    {
                        await Console.Out.WriteLineAsync("Yenı sıfrenızı giriniz");
                        string şifre2=Console.ReadLine();
                        await Console.Out.WriteLineAsync("Yenı sıfrenızı giriniz");
                        string şifre3 = Console.ReadLine();
                        if (şifre2==şifre3)
                        {
                            kontrol.Şifre = şifre2;
                            await context.SaveChangesAsync();
                            await Console.Out.WriteLineAsync("Şifreniz değişti");
                        }
                    }
                    else
                    {
                        await Console.Out.WriteLineAsync("Şifreniz uyusmuyor");
                    }
                }
                else
                {
                    await Console.Out.WriteLineAsync("Kayıt yapmak ve şifre değiştirmek ıstemedınız");
                }
            }
            else
            {
                await Console.Out.WriteLineAsync("çalışan girişi hatalı email ve şifrenizi kontrol ediniz");
            }
            await Console.Out.WriteLineAsync("Cıkıs yapmak ıcın herhangı bır yere dokunuuz");
            Console.ReadLine();
        }
        public static async void KullaniciŞifreDeğiştirme(string email, string şifre)
        {
            ProjeContext context = new();
            await Console.Out.WriteLineAsync("Şifre değiştirme sayfasına hoşgeldiniz Burada sadece kullanıcı sıfrelerı degıstırıle bılır calısanlar sıfrelerını değiştirmek ıcın hesaplarına gırıs yapmaları gerekır ");
            var kişi=await context.NormalKullanıcılars.FirstOrDefaultAsync(i=>i.Email==email && i.Şifre==şifre);
            if (kişi!=null)
            {
                await Console.Out.WriteLineAsync("Şifre değiştirme sayfasına hosgeldınız");
                await Console.Out.WriteLineAsync("Yeni şifrenizi giriniz");
                string şifre1 = Console.ReadLine();
                await Console.Out.WriteLineAsync("Yeni şifrenizi giriniz tekrar");
                string şifre2 = Console.ReadLine();
                if (şifre1==şifre2)
                {
                    kişi.Şifre = şifre1;
                    await context.SaveChangesAsync();
                    await Console.Out.WriteLineAsync("Şifeniz değişti");
                    
                }
                else
                {
                    await Console.Out.WriteLineAsync("Yeni şifreleriniz uyusmuyor");
                   
                }
            }
            else
            {
                await Console.Out.WriteLineAsync("Boyle bır kullanıcı bulunamadı");
                

            }
           
        }
        public static async void Kayıt(NormalKullanıcılar kullanıcı)
        {
            ProjeContext context = new();
             if ( !string.IsNullOrEmpty(kullanıcı.İsim) && !string.IsNullOrEmpty(kullanıcı.Soyisim) && !string.IsNullOrEmpty(kullanıcı.Email) && !string.IsNullOrEmpty(kullanıcı.Şifre))
            {
                bool kontrol = await context.NormalKullanıcılars.AnyAsync(i => i.Email == kullanıcı.Email);
                if (kontrol)
                {
                    await Console.Out.WriteLineAsync("Bu maıl alınmıs baska bır mail deneyınız ");
                }
                else
                {
                    await context.NormalKullanıcılars.AddAsync(kullanıcı);
                    await context.SaveChangesAsync();
                    await Console.Out.WriteLineAsync("Kayıdınız basarılı bır sekılde yapıldı  ");
                }

            }
            else
            {
                await Console.Out.WriteLineAsync("Bos alanları doldurup tekrarar deneyınız");
            }

        }

    }
}
