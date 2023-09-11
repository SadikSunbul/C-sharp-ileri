using Restorant.Application.Repositorys._Order;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Order
{
    public class OrderWiteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWiteRepository(RestorantDbContext context) : base(context)
        {
        }
    }
}
