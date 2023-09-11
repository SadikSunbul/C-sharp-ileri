using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Repositorys
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity
    {
        List<T> GetAll(bool Tracking=true);
        Task<T> GetByIdAsync(string id, bool Tracking = true);
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> methot, bool Tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> methot, bool Tracking = true);
        
    }
}
