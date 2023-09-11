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
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        //Zaten bız buradakı metotları yazmıstık ReadRepository de ICustomerReadRepository bu bunun dogrulayıcısı gıbı ICustomerReadRepository arayüzünü uygular.
        public CustomerReadRepository(EticaretApiDbContext context) : base(context)
        {
        }
    }
}
