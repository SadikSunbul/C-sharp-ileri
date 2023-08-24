using System;
using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .Build();


var dbName = configuration["DatabaseName"];
var userName = configuration["DefaultUserName"];

Console.WriteLine($"DbName: {dbName}, UserName: {userName}");


Console.ReadLine();