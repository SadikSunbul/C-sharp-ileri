using Restorant.Application.Repositorys._Custoemer;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Customer
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(RestorantDbContext context) : base(context)
        {
        }
    }
}
