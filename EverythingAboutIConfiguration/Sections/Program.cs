using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>(optional: true)
    .AddCommandLine(args)
    .Build();

// SECTION_NAME:CONFIG_KEY
// Terminal
// dotnet run --Database:UserName="admin"

var dbName = configuration["Database:Name"];
var userName = configuration["Database:UserName"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}");