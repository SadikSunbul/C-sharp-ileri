using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
     .AddJsonFile("appSettings.json")
     .AddEnvironmentVariables()
     .AddUserSecrets<Program>(true)
     .AddCommandLine(args)
     .Build();

// Terminal
// dotnet user-secrets init -> bin -> UserSecret.deps.json
// dotnet user-secrets set TestProd "Production"

var dbName = configuration["DatabaseName"];
var userName = configuration["DefaultUserName"];
var env = configuration["TestEnv"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}, Env: {env}");