using Eticaret.Datta_Access;
using Eticaret.Datta_Access.DbÜrünEntitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri
{
    public class DbÜrünAra
    {
        public static async Task<List<Ürün>> Ara(string ara)
        {
            EticaretContext context = new();
            var data=await context.Ürünler.Where(i => i.Acıklama.Contains(ara)).ToListAsync();
            return data;
        }

    }
}
