using Microsoft.Extensions.Configuration;
using SectionBinding;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>(optional: true)
    .AddCommandLine(args)
    .Build();

var optionModel = new DatabaseOptionModel();

configuration.GetSection("Database").Bind(optionModel);

Console.WriteLine($"DbName: {optionModel.Name}, UserName: {optionModel.UserName}");