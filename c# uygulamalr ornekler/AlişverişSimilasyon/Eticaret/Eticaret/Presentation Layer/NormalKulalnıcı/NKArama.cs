using Azure;
using Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri;
using Eticaret.Datta_Access;
using Eticaret.Datta_Access.DbGirişEntitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Presentation_Layer.NormalKulalnıcı
{
    public class NKArama
    {

        public static async Task<int> Ara(NkKullanıcı kullanıcı)
        {
            await Console.Out.WriteLineAsync("Arama menüsüne hoşgeliniz");
            await Console.Out.WriteLineAsync("Ara:");
            string ara = Console.ReadLine();
            var data = DbÜrünAra.Ara(ara);
            data.Wait();
            var data1 = data.Result;
            int i = 0;
            foreach (var item in data1)
            {
                await Console.Out.WriteLineAsync($"{i}->{item.ÜrünAdı}-{item.Fiyat}");
                i++;
            }

            await Console.Out.WriteLineAsync("Bi ürünü seçiniz");
            int secim = int.Parse(Console.ReadLine());
            ÜürnDetayları.Detay(data1[secim], kullanıcı);
            return 0;
        }
    }
}
