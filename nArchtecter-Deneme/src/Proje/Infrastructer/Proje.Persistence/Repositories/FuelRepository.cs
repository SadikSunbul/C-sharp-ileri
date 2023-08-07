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

public class FuelRepository : EfBaseRepository<Fuel, Guid, BaseContext>, IFuelRepository
{
    public FuelRepository(BaseContext context) : base(context)
    {
    }
}
