using EticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Burada IRepository bır t ıstıyor onu IReadRepository buradan cektık kıstlama gene aynı 
        //Read = select  bır verı tabanından sorgu netıcesınde verı elede edıceksen buna read ıslemı derız 
        //Tum verıler sartlı verıelr vb.
        //IQueryable olmalıdır bu sorgu demek list olmaz o ramde yapar ıslemelrı
        IQueryable<T> GetAll(bool tracking=true);
        IQueryable<T> GetWhere(Expression<Func<T,bool>>method, bool tracking = true); //burada ıcerısınde where sartı gıbı ıslem yaptırcaz sarta uygun olanalrı getırır
        Task<T> GetSingleAsync(Expression<Func<T,bool>>method, bool tracking = true); //tek verı gelıcegı ıcın IQuareble demekdık
        Task<T> GetByIdAsync(string id, bool tracking = true); //Id ye uygun olanı getırcek tek verı 


    }
}
