using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Logging;

public class LogDetail
{  //sıstemde kım ne zaman ne cagırdı 
    public string FullName { get; set; }
    public string MethotName { get; set; }
    public string User { get; set; }
    public List<LogParameter> Parameters { get; set; }

    public LogDetail()
    {
        FullName = string.Empty;
        MethotName = string.Empty;
        User = string.Empty;
        Parameters = new List<LogParameter>();
    }
    public LogDetail(string fullName, string methotName, string user, List<LogParameter> parameters)
    {
        FullName = fullName;
        MethotName = methotName;
        User = user;
        Parameters = parameters;
    }
}
