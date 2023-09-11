using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Persistence
{
    public static class Configration
    {
        static public string ConnectionString
        {
            get
            {
                //Microsoft.Extensions.Configuration bu kutuphane ınmelı appsetıngsten verıyı cekmek ıcın 
                ConfigurationManager configurationManager = new();
                //Microsoft.Extensions.Configuration.json buda ınmelı baska bı katmandakı dosyaya erısmek ıcın 
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EticaretApi.Api"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MsSql");
            }
        }
    }
}
