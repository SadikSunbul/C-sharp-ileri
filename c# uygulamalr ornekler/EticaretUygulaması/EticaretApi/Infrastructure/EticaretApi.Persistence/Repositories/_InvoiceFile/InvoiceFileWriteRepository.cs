using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities._File;
using EticaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence.Repositories._InvoiceFile
{
    public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(EticaretApiDbContext context) : base(context)
        {
        }
    }
}
