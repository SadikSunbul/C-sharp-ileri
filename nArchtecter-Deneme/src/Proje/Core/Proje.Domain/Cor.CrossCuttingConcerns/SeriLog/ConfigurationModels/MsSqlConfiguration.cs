using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.SeriLog.ConfigurationModels;

public class MsSqlConfiguration
{
    public string ConnectionString { get; set; }
    public string TableName { get; set; }
    public bool AutoCreateSqlTable { get; set; }
    public MsSqlConfiguration()
    {
        ConnectionString = string.Empty;
        TableName = string.Empty;
        AutoCreateSqlTable = true;
    }
    public MsSqlConfiguration(string connectionString, string tablName, bool autoCreateSqlTable)
    {
        ConnectionString = connectionString;
        TableName = tablName;
        AutoCreateSqlTable = autoCreateSqlTable;
    }
}
