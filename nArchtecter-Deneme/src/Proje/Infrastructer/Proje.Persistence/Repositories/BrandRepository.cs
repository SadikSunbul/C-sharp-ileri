using Proje.Application.Services.Repository;
using Proje.Domain.Core.Persistance.Repositories;
using Proje.Domain.Entities;
using Proje.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistence.Repositories;

public class BrandRepository : EfBaseRepository<Brand, Guid, BaseContext>, IBrandRepository
{
    public BrandRepository(BaseContext context) : base(context)
    {
    }
}
