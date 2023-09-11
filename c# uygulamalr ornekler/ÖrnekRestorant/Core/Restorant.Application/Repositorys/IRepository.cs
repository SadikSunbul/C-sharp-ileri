using Microsoft.EntityFrameworkCore;
using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Repositorys
{
    public interface IRepository<T> where T : BaseEntity
    {
         DbSet<T> Table { get; }
    }
}
