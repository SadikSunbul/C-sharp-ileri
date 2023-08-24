using MassTransit;
using Payment.Api.Consumers;
using Shared;
using Stock.Api.Consummers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Rabbit mq entegrasyon sagland�
builder.Services.AddMassTransit(configurator =>
{   //Consumerlar� bildiriyoruz
    configurator.AddConsumer<StockReservedEventConsumer>();
    configurator.UsingRabbitMq((context, _configurator) =>
    {
        _configurator.Host(builder.Configuration["RabbitMQ"]);
        _configurator.ReceiveEndpoint(RabbitMqSettings.Payment_StockReservedEventQueue, e => e.ConfigureConsumer<StockReservedEventConsumer>(context));//hangi kurugu d�nl�ycek onu burada bel�r�tyoruz 
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
