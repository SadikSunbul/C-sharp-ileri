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
    public class DbSepet
    {

        public static async Task<bool> SepeteEkle(NkKullanıcı _kullanıcı,Ürün _ürün)
        {
            EticaretContext context = new();

            Sepet sepet = new()
            {
                ürün = _ürün,
                NkKullanıcı = _kullanıcı
            };

            try
            {
                await context.Sepetler.AddAsync(sepet);
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
