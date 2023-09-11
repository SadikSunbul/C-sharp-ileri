using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys._Basket;
using Restorant.Application.ViewModel._Basket;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Basket
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(RestorantDbContext context) : base(context)
        {
            Context = context;
        }

        public RestorantDbContext Context { get; }

        public async Task<List<VM_Basket_List>> basket_Lists(Customer cutomer)
        {
            List<VM_Basket_List> vMs = new();
            var data = await Context.Baskets.Include(i => i.Food).Where(i => i.Customer.Id == cutomer.Id).ToListAsync();
            foreach (var item in data)
            {
                VM_Basket_List l = new()
                {
                    Adet = item.Adet,
                    BasketId = item.Id,
                    Price = item.Food.Price,
                    TotalPrice = item.Adet * item.Food.Price,
                    YemekAdı = item.Food.Name
                };
                vMs.Add(l);
            }
            return vMs;
        }
    }
}
