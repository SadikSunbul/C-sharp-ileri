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
    public class DbYorumYap
    {

        public static async Task<bool> Yorum (string _yorum,Ürün _ürün)
        {
            EticaretContext context = new();
            _ürün.Yorumlar.Add(new Yorum()
            {
                 Yorumm=_yorum
            });
            try
            {
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
