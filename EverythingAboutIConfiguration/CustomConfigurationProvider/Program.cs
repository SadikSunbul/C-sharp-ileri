using CustomConfigurationProvider;
using Microsoft.Extensions.Configuration;
using System.IO;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(inMemoryConfigs())
    .Add(new CustomConfigSource())
    .Build();



var dbName = configuration["Database:Name"];
var userName = configuration["Database:UserName"];
var env = configuration["Environment"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}, Env: {env}");





#region InMemoryCollection

Dictionary<string, string> inMemoryConfigs()
{
    return new()
    {
        { "Environment","Environment from IN_MEMORY" }
    };
}

#endregion