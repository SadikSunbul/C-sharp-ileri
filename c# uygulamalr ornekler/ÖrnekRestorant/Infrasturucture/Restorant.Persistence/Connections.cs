using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence
{
    public static class Connections
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Restorant.Api"));
                configurationManager.AddJsonFile("appsettings.json");
                return  configurationManager.GetConnectionString("MsSql");
            }
        }
    }
}
