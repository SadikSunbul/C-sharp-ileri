using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities.Common;
using EticaretApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly EticaretApiDbContext _context; //IoC den gelicek 
        public ReadRepository(EticaretApiDbContext context)
        {
            _context = context;
        }
        //burası IRepository den geldi
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        /*=> Table; //tum tanloları getırıcek*/
        {
            var query = Table.AsQueryable(); //sorgu seklinde dursun dedık 
            if (!tracking)
            {
                query = query.AsNoTracking(); //trackıng devredısı oldu 
            }
            return query;
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        //=> Table.Where(method);
        {
            var query = Table.Where(method);
            if (!tracking)
            {
                query = query.AsNoTracking(); //trackıng devredısı oldu 
            }
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        //=> await Table.FirstOrDefaultAsync(method);
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking(); //trackıng devredısı oldu 
            }
            return await query.FirstOrDefaultAsync(method);
        }


        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        /*=>await Table.FindAsync(Guid.Parse(id));*/ //Id yı guid e pars ettık esıtse dondur dedık 
        {
            var query=Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking(); //trackıng devredısı oldu 
            }
            return await query.FirstOrDefaultAsync(i => i.Id == Guid.Parse(id));
        }
    }
}
