using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>(optional: true)
    .AddCommandLine(args)
    .Build();

var dbSection = configuration.GetSection("Database");

var dbName = dbSection["Name"];
var userName = dbSection["UserName"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}");