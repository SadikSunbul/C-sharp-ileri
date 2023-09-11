using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using EticaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EticaretApiDbContext context) : base(context)
        {
        }
    }
}
