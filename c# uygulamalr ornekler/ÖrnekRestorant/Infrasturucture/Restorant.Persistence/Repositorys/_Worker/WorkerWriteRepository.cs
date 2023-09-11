using Restorant.Application.Repositorys._Worker;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Worker
{
    public class WorkerWriteRepository : WriteRepository<Worker>, IWorkerWriteRepository
    {
        public WorkerWriteRepository(RestorantDbContext context) : base(context)
        {
        }
    }
}
