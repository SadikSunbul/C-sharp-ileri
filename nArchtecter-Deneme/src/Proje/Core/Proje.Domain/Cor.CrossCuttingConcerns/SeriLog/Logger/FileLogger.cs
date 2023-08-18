using Microsoft.Extensions.Configuration;
using Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.ConfigurationModels;
using Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.Messages;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.Loggers;

public class FileLogger : LoggerServiceBase
{
    private readonly IConfiguration configuration;

    public FileLogger(IConfiguration configuration)
    {
        this.configuration = configuration;

        FileLogConfiguration logConfig = configuration.GetSection("SeriLogConfigurations:FileLogConfiguration").Get<FileLogConfiguration>() ?? throw new Exception(SeriLogMessages.NullOptionsMessage);//ORDAKI YOLU AL BURADAKI NESNEYE MAP LE sınıfta zanten sadece path var yok ıse hata fırlat

        string logFilePath = string.Format(format: "{0}{1}", arg0: Directory.GetCurrentDirectory() + logConfig.FolderPath, arg1: ".txt"); //kaydedıcegımız yer 

        Logger = new LoggerConfiguration().WriteTo.File(
            logFilePath,
            rollingInterval: RollingInterval.Day,
            retainedFileCountLimit: null,
            fileSizeLimitBytes: 5000000,
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}")
            .CreateLogger();
    }
}
