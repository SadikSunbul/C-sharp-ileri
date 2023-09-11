using Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri;
using Eticaret.Datta_Access;
using Eticaret.Datta_Access.DbGirişEntitys;
using Eticaret.Datta_Access.DbÜrünEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Presentation_Layer.NormalKulalnıcı
{
    public class ÜürnDetayları
    {
        public static async void Detay(Ürün ürün,NkKullanıcı kullanıcı)
        {
            EticaretContext context = new();
            Console.WriteLine($"{ürün.ÜrünAdı}");
            Console.WriteLine($"{ürün.Fiyat}");
            Console.WriteLine($"{ürün.Acıklama}");
            Console.WriteLine($"{ürün.Beğenisayısı}");
            Console.WriteLine($"{ürün.SatısSayısı}");

            await context.Entry(ürün).Reference(i => i.satıcı).LoadAsync();
            await Console.Out.WriteLineAsync($"{ürün.satıcı.İsim}");
            await Console.Out.WriteLineAsync($"{ürün.satıcı.ŞirketAdı}");

            await Console.Out.WriteLineAsync("-----------Yorumlar----------");

            await context.Entry(ürün).Collection(i => i.Yorumlar).LoadAsync();

            foreach (var item in ürün.Yorumlar)
            {
                await Console.Out.WriteLineAsync($"{item.Yorumm}-{item.YorumAtılmaZamanı}");
                await Console.Out.WriteLineAsync(".............*.............");
            }
            await Console.Out.WriteLineAsync("-------------------------------");
            await Console.Out.WriteLineAsync("Bu ürün üstünde yapışlacak işlemler");
            await Console.Out.WriteLineAsync("1->Beğen");
            await Console.Out.WriteLineAsync("2->Sepete Ekle");
            await Console.Out.WriteLineAsync("3->Yorum yap");
            await Console.Out.WriteLineAsync("4->Ana sayfaya dön");

            await Console.Out.WriteLineAsync("Lütfen birini seçiniz:");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    DbÜrünBeğen.Beğen(ürün, kullanıcı).Wait();
                    break;
                case 2:
                    DbSepet.SepeteEkle(kullanıcı, ürün).Wait();
                    break;
                case 3:
                    await Console.Out.WriteLineAsync("Yorum:");
                    string yorum=Console.ReadLine();
                    if (yorum!=null)
                    {
                        DbYorumYap.Yorum(yorum, ürün).Wait();
                    }
                    else
                    {
                        await Console.Out.WriteLineAsync("Yorum bolumu bos gecılemez");
                    }
                    
                    break;
                case 4:
                    NormalKullanıcıAnamenü.Anamenü(kullanıcı);
                    break;
                default:
                    await Console.Out.WriteLineAsync("Hatalı gırıs");
                    Detay(ürün, kullanıcı);
                    break;
            }

        }
    }
}
