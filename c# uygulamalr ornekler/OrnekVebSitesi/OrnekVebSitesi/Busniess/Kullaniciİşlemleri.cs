using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrnekVebSitesi.Models.EfCore;
using OrnekVebSitesi.Models.EfCore.Entities;
using OrnekVebSitesi.Models.ViewModel;
using System.Threading.Tasks;
using System.Transactions;

namespace OrnekVebSitesi.Busniess
{
    public  class Kullaniciİşlemleri
    {

        public static async Task<bool> Kayıt(Kullanıcı kullanıcı)
        {
            kullanıcı.Şifre = Şifreİşlemleri.HashSifre(kullanıcı.Şifre);
            using (EticaretContext context = new EticaretContext())
            {
                using var transaction = await context.Database.BeginTransactionAsync();

                try
                {
                    await context.Kullanıcılar.AddAsync(kullanıcı);
                    await context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return true;
                }
                catch (System.Exception)
                {
                    await transaction.RollbackAsync();
                    return false;
                }
            }
                
        }

        public static async Task<(bool,int?)> Giriş(KullaniciGirişiViewModel kullanici)
        {
            

            using (EticaretContext context = new EticaretContext())
            {
               var data= await context.Kullanıcılar.FirstOrDefaultAsync(i => i.Email == kullanici.Mail && i.Şifre == Şifreİşlemleri.HashSifre(kullanici.Şifre));

                if (data!=null)
                {
                    return (true,data.Id);
                }
                else
                {
                    return (false, null);
                }
            }
        }
    }
}
