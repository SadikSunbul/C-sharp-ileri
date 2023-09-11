using Eticaret.Datta_Access;
using Eticaret.Datta_Access.DbGirişEntitys;
using Eticaret.Datta_Access.DbÜrünEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri
{
    public class DbÜrünBeğen
    {

        public static async Task<bool> Beğen(Ürün _ürün,NkKullanıcı _kullanıcı)
        {
            EticaretContext context = new();
            Favori favori = new()
            {
                 ürün=_ürün,
                 NkKullanıcı=_kullanıcı
            };
            try
            {
                await context.Favoriler.AddAsync(favori);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
