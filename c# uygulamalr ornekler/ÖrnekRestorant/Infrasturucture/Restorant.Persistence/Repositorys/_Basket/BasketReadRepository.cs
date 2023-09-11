using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys._Basket;
using Restorant.Application.Repositorys._Order;
using Restorant.Application.ViewModel._Basket;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using Restorant.Persistence.Repositorys._Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Basket
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(RestorantDbContext context) : base(context)
        {
           
        }

        
    }
}
