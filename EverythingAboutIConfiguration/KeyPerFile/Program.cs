using Microsoft.Extensions.Configuration;

var path = Path.Combine(Directory.GetCurrentDirectory(), "./Files");

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddKeyPerFile(directoryPath: path, optional: true)
    .AddUserSecrets<Program>(optional: true)
    .Build();

var dbName = configuration["Database:Name"];
var userName = configuration["Database:UserName"];
var env = configuration["Environment"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}, Env: {env}");