using Microsoft.Extensions.Configuration;
using Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.ConfigurationModels;
using Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.Messages;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.Loggers;

public class MsSqlLogger : LoggerServiceBase
{
    public MsSqlLogger(IConfiguration configuration)
    {
        MsSqlConfiguration logConfig = configuration.GetSection("SeriLogConfigurations:MsSqlConfiguration").Get<MsSqlConfiguration>() ?? throw new Exception(SeriLogMessages.NullOptionsMessage);

        MSSqlServerSinkOptions sinkOptions = new()
        {
            TableName = logConfig.TableName,
            AutoCreateSqlDatabase = logConfig.AutoCreateSqlTable
        };

        ColumnOptions columnOptions = new(); //MsSql için default kulalnıcaz

        global::Serilog.Core.Logger seriLogConfig = new LoggerConfiguration().WriteTo.MSSqlServer(logConfig.ConnectionString, sinkOptions, columnOptions: columnOptions).CreateLogger();

        Logger = seriLogConfig;
    }
}
