using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace globalCRUD
{
    public class curudıslemelrıglobal
    {

        public void VeriEkle<T>(T veri, TetstContext context) where T : class  //burada gelen t nın cllas olması gerektıgını soyluyor
        {
            context.Set<T>().Add(veri);
            context.SaveChanges();
        }

        /// <summary>
        /// burada verıyı guncellerken Id degerının verılmesı gerekır 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="veri"></param>
        /// <param name="context"></param>
        public void VeriGüncelle<T>(T veri, TetstContext context) where T : class  //burada gelen t nın cllas olması gerektıgını soyluyor
        {
            context.Set<T>().Update(veri);
            context.SaveChanges();
        }
        /// <summary>
        /// burda sılınecek verının ıd degerıde verılmelıdır ıstersenız ılk basta verıyı elde edıp sonra sılme ıslemı yapabılrısınız
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="veri"></param>
        /// <param name="context"></param>
        public void VeriSil<T>(T veri, TetstContext context) where T : class  //burada gelen t nın cllas olması gerektıgını soyluyor
        {
            context.Set<T>().Remove(veri);
            context.SaveChanges();
        }

        /*
         context.Set<T>() ifadesi, veritabanındaki T türündeki nesneleri temsil eden bir DbSet nesnesini döndürür. Burada "T" yerine, "veri" parametresinin türü geçirilir ve ilgili DbSet nesnesi döndürülür.
         */

    }
}
