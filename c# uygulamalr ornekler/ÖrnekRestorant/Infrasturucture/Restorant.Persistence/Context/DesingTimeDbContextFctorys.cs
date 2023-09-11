using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Context
{
    internal class DesingTimeDbContextFctorys : IDesignTimeDbContextFactory<RestorantDbContext>
    {
        public RestorantDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<RestorantDbContext> contextOptionsBuilder = new();
            contextOptionsBuilder.UseSqlServer(Connections.ConnectionString);
            return new (contextOptionsBuilder.Options);
        }
    }
}
