using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Repositories;

public interface IQuery<TEntity>
{//burada temel sorguyu olusturcaz soylekı contex.set<...>().AsQuerayable() gibi
    IQueryable<TEntity> Query();
}
