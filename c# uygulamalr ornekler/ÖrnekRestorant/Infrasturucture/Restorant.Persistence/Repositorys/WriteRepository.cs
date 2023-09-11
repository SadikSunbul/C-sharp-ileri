using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys;
using Restorant.Domain.Entiteis.Common;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly RestorantDbContext context;

        public WriteRepository(RestorantDbContext context)
        {
            this.context = context;
        }
        public DbSet<T> Table => context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            var data = await Table.AddAsync(model);
            return data.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            var data = Table.Remove(model);
            return data.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var data = await Table.FirstOrDefaultAsync(i => i.Id == Guid.Parse(id));
            return Remove(data);
        }

        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            var data =await context.SaveChangesAsync();
            return data>0;
        }

        public bool Update(T model)
        {
            var data=Table.Update(model);
            return  data.State == EntityState.Modified;
        }
    }
}
