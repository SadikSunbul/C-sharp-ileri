using Proje.Application;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Extenrions;
using Proje.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceService(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (app.Environment.IsProduction())
{
    app.ConfigureCustomExceptionMiddleware();
    //kullan�c� �c�n bu hata yontem�n� kullan
    //developera daha fazla b�r b�lg� vermes� laz�m b�ze laz�m 
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
