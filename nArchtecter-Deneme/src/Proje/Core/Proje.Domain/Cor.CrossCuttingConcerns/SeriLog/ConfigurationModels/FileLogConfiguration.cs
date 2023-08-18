using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.ConfigurationModels;

public class FileLogConfiguration
{
    //Dosyalamöa ıcın bunlar yetıcektır 
    public string FolderPath { get; set; }

    public FileLogConfiguration()
    {
        FolderPath = string.Empty;
    }
    public FileLogConfiguration(string folderPath)
    {
        FolderPath = folderPath;
    }
}
