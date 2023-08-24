using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApiNamed;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DatabaseOptionModel>("SqlDB", builder.Configuration.GetSection("SqlDatabase"));
builder.Services.Configure<DatabaseOptionModel>("OracleDB", builder.Configuration.GetSection("OracleDatabase"));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();


app.MapGet("/Sql", ([FromServices] IOptionsSnapshot<DatabaseOptionModel> options) =>
{
    var data = options.Get(name: "SqlDB");

    return $"DbName: {data.Name}, UserName: {data.UserName}";
})
.WithDisplayName("Get");

app.MapGet("/Oracle", ([FromServices] IOptionsSnapshot<DatabaseOptionModel> options) =>
{
    var data = options.Get(name: "OracleDB");

    return $"DbName: {data.Name}, UserName: {data.UserName}";
})
.WithDisplayName("Get");

app.Run();