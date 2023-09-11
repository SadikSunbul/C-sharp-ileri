using Eticaret.Datta_Access;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri
{
    public class DbMailKontrol
    {
        /// <summary>
        /// true donerse maıl var demek false donerse mail yok demek
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public async static Task<bool> kontrol(string mail)
        {
            EticaretContext context = new();

            var data=await context.kİşiler.FirstOrDefaultAsync(i=>i.Mail==mail);
            if (data!=null)
            {
                return true;

            }
            else
            {
                return false;
            } 
        }
    }
}
