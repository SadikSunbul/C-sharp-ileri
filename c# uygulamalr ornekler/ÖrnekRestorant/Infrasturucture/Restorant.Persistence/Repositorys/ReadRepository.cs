using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys;
using Restorant.Domain.Entiteis.Common;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly RestorantDbContext context;

        public ReadRepository(RestorantDbContext context)
        {
            this.context = context;
        }
        public DbSet<T> Table =>context.Set<T>();

        public List<T> GetAll(bool Tracking = true)
        {
            var data =Table.AsQueryable();
            if (!Tracking)
            {
                data.AsNoTracking();
            }
            return data.ToList();
        }

        public async Task<T> GetByIdAsync(string id, bool Tracking = true)
        {
            var data = Table.AsQueryable();
            if (!Tracking)
            {
                data.AsNoTracking();
            }
            return await data.FirstOrDefaultAsync(i=>i.Id==Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> methot, bool Tracking = true)
        {
            var query = Table.AsQueryable();
            if (!Tracking)
            {
                query = query.AsNoTracking(); //trackıng devredısı oldu 
            }
             var data =await query.FirstOrDefaultAsync(methot);
            return data;
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> methot, bool Tracking = true)
        {
            var data = Table.AsQueryable();
            if (!Tracking)
            {
                data.AsNoTracking();
            }
            return await data.Where(methot).ToListAsync();
        }
    }
}
