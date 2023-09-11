using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities.Common;
using EticaretApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly EticaretApiDbContext _context; //IoC den gelicek 
        public WriteRepository(EticaretApiDbContext context)
        {
            _context=context;
        }

        public DbSet<T> Table => _context.Set<T>(); //ılgılı tablo elde edıldı 

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;//eklememı degılmı onun kontrolunu yapıyor 
        }
        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }


        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model=await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model); //ustekı remove metodunu cagırdık 
        }


        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State==EntityState.Modified;
        }

        public async Task<int> SaveAsync()
        =>await _context.SaveChangesAsync();

       
    }
}
