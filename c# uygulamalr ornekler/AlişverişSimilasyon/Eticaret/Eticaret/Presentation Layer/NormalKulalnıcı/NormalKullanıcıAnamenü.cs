using Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri;
using Eticaret.Business_Process_Layer.KullanıcıNınİşlemelri;
using Eticaret.Datta_Access.DbGirişEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Presentation_Layer.NormalKulalnıcı
{
    public class NormalKullanıcıAnamenü
    {
        public static void Anamenü(NkKullanıcı kullanıcı)
        {
            Console.WriteLine($"Normal Kullannıcı Ana sayfasına hoşgeldizniz:{kullanıcı.İsim}");
            Console.WriteLine("1->Arama");
            Console.WriteLine("2->Trentler/Çoksatanlar");
            Console.WriteLine("3->Favorilerim");
            Console.WriteLine("4->Sepetim");
            Console.WriteLine("5->Ayarlar");

            Console.WriteLine("Lütfen birini seçiniz:");
            int seçim = int.Parse(Console.ReadLine());

            switch (seçim)
            {
                case 1:
                    NKArama.Ara(kullanıcı).Wait();
                    break;
                case 2:

                    break;
                case 3:
                    var data=FavorilerimiListele.Favorilerim(kullanıcı);
                    data.Wait();
                    var data1 = data.Result;
                    int c = 0;
                    foreach (var item in data1)
                    {
                        Console.WriteLine($"{c}->{item.ürün.ÜrünAdı}");
                    }
                    Console.WriteLine("Birini seçiniz:");
                    int deger = int.Parse(Console.ReadLine());

                    ÜürnDetayları.Detay(data1[deger].ürün,kullanıcı);

                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    Anamenü(kullanıcı);
                    break;
            }

        }
    }
}
