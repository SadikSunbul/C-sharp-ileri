var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


int workerTred, threads;
ThreadPool.GetAvailableThreads(out workerTred,out threads); //uygulamada akt�f olarak kac tred var onu goster�yor
// Environment.ProcessorCount //bilgisayardak� cek�rdek say�s�n� ver�r
var success=ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount); //deger� deg�st�r�yor


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
