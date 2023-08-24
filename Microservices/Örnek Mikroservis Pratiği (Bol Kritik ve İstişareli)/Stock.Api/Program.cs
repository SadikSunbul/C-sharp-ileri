using MassTransit;
using Microsoft.EntityFrameworkCore;
using Shared;
using Stock.Api.Consummers;
using Stock.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<StockDbContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("mssql"));
});

//Rabbit mq entegrasyon sagland�
builder.Services.AddMassTransit(configurator =>
{   //Consumerlar� bildiriyoruz
    configurator.AddConsumer<OrderCreatedEventConsummer>();
    configurator.UsingRabbitMq((context, _configurator) =>
    {
        _configurator.Host(builder.Configuration["RabbitMQ"]);
        _configurator.ReceiveEndpoint(RabbitMqSettings.Stock_OrderCreatedEventQueue, e => e.ConfigureConsumer<OrderCreatedEventConsummer>(context));//hangi kurugu d�nl�ycek onu burada bel�r�tyoruz 
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
