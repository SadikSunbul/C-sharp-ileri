using Restorant.Application.Repositorys._Table;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Table
{
    public class TableWriteRepository : WriteRepository<Table>, ITableWriteRepository
    {
        public TableWriteRepository(RestorantDbContext context) : base(context)
        {
        }
    }
}
