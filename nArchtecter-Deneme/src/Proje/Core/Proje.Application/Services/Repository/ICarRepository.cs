using Proje.Domain.Core.Persistance.Repositories;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Services.Repository;

public interface ICarRepository : IAsyncRepository<Car, Guid>
{

}