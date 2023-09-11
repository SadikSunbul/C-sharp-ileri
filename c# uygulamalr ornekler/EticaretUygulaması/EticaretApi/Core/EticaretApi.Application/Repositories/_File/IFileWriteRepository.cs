using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Repositories
{
    public interface IFileWriteRepository:IWriteRepository<Domain.Entities._File.File>
    {
    }
}
