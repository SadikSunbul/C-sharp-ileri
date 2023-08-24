using Microsoft.Extensions.Configuration;

var mappings = new Dictionary<string, string>
{
    { "--DbName", "Database:Name" },
    { "--DbUser", "Database:UserName" },
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>(optional: true)
    .AddCommandLine(args, mappings)
    .Build();

// Terminal
//dotnet run --DbName "TechBuddy"

var dbName = configuration["Database:Name"];
var userName = configuration["Database:UserName"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}");