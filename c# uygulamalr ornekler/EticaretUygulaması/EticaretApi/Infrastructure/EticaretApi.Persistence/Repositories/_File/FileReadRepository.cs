using EticaretApi.Application.Repositories;
using EticaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence.Repositories._File
{
    public class FileReadRepository : ReadRepository<Domain.Entities._File.File>, IFileReadRepository
    {
        public FileReadRepository(EticaretApiDbContext context) : base(context)
        {
        }
    }
}
