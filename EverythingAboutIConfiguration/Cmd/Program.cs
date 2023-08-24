using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

// terminal
// dotnet run --TestEnv=prod


var dbName = configuration["DatabaseName"];
var userName = configuration["DefaultUserName"];
var env = configuration["TestEnv"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}, Env: {env}");