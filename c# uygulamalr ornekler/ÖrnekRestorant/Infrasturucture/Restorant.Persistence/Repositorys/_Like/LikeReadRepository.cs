using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys._Like;
using Restorant.Application.ViewModel._Like;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Like
{
    public class LikeReadRepository : ReadRepository<Like>, ILikeReadRepository
    {

        public LikeReadRepository(RestorantDbContext context) : base(context)
        {
            

        }

        


    }
}
