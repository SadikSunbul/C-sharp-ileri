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
    //kullanýcý ýcýn bu hata yontemýný kullan
    //developera daha fazla býr býlgý vermesý lazým býze lazým 
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
