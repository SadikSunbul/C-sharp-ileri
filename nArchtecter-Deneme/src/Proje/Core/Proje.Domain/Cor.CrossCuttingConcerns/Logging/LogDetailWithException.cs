using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Logging;

public class LogDetailWithException : LogDetail
{
    //hata olan durumlarda kullnıcaz
    public string ExceptionMessage { get; set; }
    public LogDetailWithException()
    {
        ExceptionMessage = String.Empty;
    }
    public LogDetailWithException(string fullName, string methotName, string user, List<LogParameter> parameters, string excepsionMessage) : base(fullName, methotName, user, parameters)
    {
        ExceptionMessage = excepsionMessage;
    }
}
