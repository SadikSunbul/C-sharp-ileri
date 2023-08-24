using Microsoft.AspNetCore.Mvc;
using Validation;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOptions<DatabaseOptionModel>()
    .BindConfiguration("Database")
    .ValidateDataAnnotations()
    //.Validate(config =>
    //{
    //    // multiple checks

    //    return !string.IsNullOrEmpty(config.Name);
    //}, "DatabaseName cannot be empty")
    .ValidateOnStart();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => { return "WORKED"; });

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.Run();
