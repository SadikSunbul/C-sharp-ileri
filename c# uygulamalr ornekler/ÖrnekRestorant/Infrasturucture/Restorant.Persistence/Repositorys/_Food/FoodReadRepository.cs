using Restorant.Application.Repositorys._Food;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Food
{
    public class FoodReadRepository : ReadRepository<Food>, IFoodReadRepository
    {
        public FoodReadRepository(RestorantDbContext context) : base(context)
        {
        }
    }
}
