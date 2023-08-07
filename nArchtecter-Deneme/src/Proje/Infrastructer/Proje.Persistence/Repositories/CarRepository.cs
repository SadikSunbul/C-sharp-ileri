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

public class CarRepository : EfBaseRepository<Car, Guid, BaseContext>, ICarRepository
{
    public CarRepository(BaseContext context) : base(context)
    {
    }
}
