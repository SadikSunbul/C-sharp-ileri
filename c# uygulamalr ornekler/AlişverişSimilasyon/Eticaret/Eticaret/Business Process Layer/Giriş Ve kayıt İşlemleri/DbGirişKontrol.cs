using Eticaret.Datta_Access;
using Eticaret.Datta_Access.DbGirişEntitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri
{
    public class DbGirişKontrol
    {

        /// <summary>
        /// burada drekt olarak kişiyi donsurucem avrsa boyle biri kontrol et ıcerıde 
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public async static Task<Kişi> kontrol(string mail,string şifre)
        {
            EticaretContext context = new();

            var data = await context.kİşiler.FirstOrDefaultAsync(i => i.Mail == mail && i.Şifre==şifre);

            return data;
        }
    }
}
