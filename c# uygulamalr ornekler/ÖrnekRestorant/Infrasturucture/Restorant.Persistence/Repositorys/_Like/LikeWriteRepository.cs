using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys._Like;
using Restorant.Application.ViewModel._Like;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Like
{
    public class LikeWriteRepository : WriteRepository<Like>, ILikeWriteRepository
    {
        public LikeWriteRepository(RestorantDbContext context) : base(context)
        {
            Context = context;
        }

        public RestorantDbContext Context { get; }

        public async Task<List<VM_Like_List>> like_Lists(Customer customer)
        {
            List<VM_Like_List> vM_s = new();
            var data=await Context.Likes.Include(i => i.Food).Where(i => i.CustomerId == customer.Id).ToListAsync();

            foreach (var item in data)
            {
                VM_Like_List l = new();
                l.LikeId=item.Id;
                l.YemekId=item.Food.Id;
                l.Fiyat = item.Food.Price;
                l.İsim = item.Food.Name;
                vM_s.Add(l);
            }
            return vM_s;
        }
    }
}
