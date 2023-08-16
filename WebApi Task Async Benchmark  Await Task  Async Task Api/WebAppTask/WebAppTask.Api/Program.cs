var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


int workerTred, threads;
ThreadPool.GetAvailableThreads(out workerTred,out threads); //uygulamada aktýf olarak kac tred var onu gosterýyor
// Environment.ProcessorCount //bilgisayardaký cekýrdek sayýsýný verýr
var success=ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount); //degerý degýstýrýyor


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
