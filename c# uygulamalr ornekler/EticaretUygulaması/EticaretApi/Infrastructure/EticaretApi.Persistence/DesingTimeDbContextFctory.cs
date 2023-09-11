using EticaretApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence
{
    public class DesingTimeDbContextFctory : IDesignTimeDbContextFactory<EticaretApiDbContext>
    {
        //.net cl de hata var oyuzden boyle ıolusturulmalıdır 
        public EticaretApiDbContext CreateDbContext(string[] args)
        {
           
            DbContextOptionsBuilder<EticaretApiDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configration.ConnectionString);
            return new (dbContextOptionsBuilder.Options);
        }
    }
}
