using EticaretApi.Application;
using EticaretApi.Application.Abstractions.Storage;
using EticaretApi.Application.Validaters._Product;
using EticaretApi.Infrastructure;
using EticaretApi.Infrastructure.Enums;
using EticaretApi.Infrastructure.Filters;
using EticaretApi.Infrastructure.Services.Stogare;
using EticaretApi.Infrastructure.Services.Stogare.Azure;
using EticaretApi.Infrastructure.Services.Stogare.Local;
using EticaretApi.Persistence;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//kendý olusturdugumuz verýyý tetýklýyoz 
builder.Services.AddPersistenceServices();
//builder.Services.AddScoped<IStorageService, StorageService>();
//builder.Services.AddStorage<LocalStorage>();
builder.Services.AddAplicationService();
builder.Services.AddInfrastructureServices();
//Crospolitikalarý
//builder.Services.AddCors(options=>options.AddDefaultPolicy(policy=>policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin())); //burada her yerden verý alýr kullanýlmaz bu 
builder.Services.AddCors(options=>options.AddDefaultPolicy(policy=>policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod())); //sadece bu sýteden gelen verýlerý alýcaktýr 


//Validation
builder.Services.AddControllers().AddFluentValidation(c=>c.RegisterValidatorsFromAssemblyContaining<CreateProductValidater>());
//builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>()).AddFluentValidation(configration => configration.RegisterValidatorsFromAssemblyContaining<CreateProductValidater>())
  //  .ConfigureApiBehaviorOptions(option => option.SuppressModelStateInvalidFilter = true);//fluent valýdater ý aktýflestýrdýk sadece product creat ýcýn degýl dýgerlerýnýde yazýnca ayný dýzýnde olduklarý ýcýn hepsýný ceker
//burada true yaptýgýmýz ýcýn filter olusturmamýz gerekýr býr servister filter o zmn Infrastructure de olusturcaz
builder.Services.AddEndpointsApiExplorer();

//File servis ekeleme
//builder.services.addstorage<localstorage>();
builder.Services.AddStorage<LocalStorage>(); //Local olarak ýlerlýyecektýr burada aws dersek aws olarak ýlerýler
/*builder.Services.AddStorage(StorageType.Local);*///usteký ýle ayný 
/*builder.Services.AddStorage<LocalStorage>();*/ //tek býr degýsýklýlýkle dosya kaydýný Azurestorage seklýnde yapmýs olduk 

builder.Services.AddSwaggerGen();




builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)//JwtBearerDefaults.AuthenticationScheme deafult sema 
    .AddJwtBearer("Admin",options => //dogrulamanýn yapýldýgý yer
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, //olustuurlacak token degerýný kýmleýrn hangý orjýnlerýn sýtelrýn kullanacagýný belýrtýgýmýz deger www.býlemmne.com
            ValidateIssuer = true, //olusturulacak token degerýný kýmýn dagýttýný ýfade edecegýmýz alandýr  www.myapi.com
            ValidateLifetime = true,  //Olusturulan token degerýnýn suresýný kontrol edecek olan dogrulamadýr 
            ValidateIssuerSigningKey = true,  //Üretilecek token degerýnýn uygulamamýza aýt býr deger oldugunu ýfade eden sucýry key verýsýnýn dogrulanmasýdýr.
            ValidAudience = builder.Configuration["Token:Audience"], //www.bilmemne.com
            ValidIssuer = builder.Configuration["Token:Issuer"], //www.myapi.com"
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"]))
        };
    }); //Hangý oturesýn servisi AddJwtBearer sectýk





var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Uste yapmýs oldugumu cors polýtýkasýnýn mýdel waresýný ekledýk buraya 
app.UseCors();
//wwwroot ýcýn kullanýlýr 
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthentication(); //burayý eklemeyý unutma 
app.UseAuthorization();

app.MapControllers();

app.Run();

#region Cros Politikasý nedir

//Apiler uzerýnden browserýn almýs oldugu dosal same-orgýn polýcy onlemýný hafýfletme polýtýkasýdýr

//Egerký clýent uygulamasý browser da calýsýyorsa burada cros polýtýkasý soz konusudur 
//Browserlarýn bu davranýsýna same-orgin polýtc denýr
//Browserlar dogal olarak almýs olduklarý Same-orgin polýcy onlemýný asabýlmnek için clýent uygulamasýnýn ýstek gonderdýgi hedef sýteye orgýne endpoýnte api e oncelýklý gýdýp bu sýteden gelecek olan requestlere ýzýn olup olmadýgýný soracakardýndan ýstegý ya ýptal edýcek ya da ýzýn verýcektýr.

#endregion

#region Filter olusrturma

//burada true yaptýgýmýz ýcýn filter olusturmamýz gerekýr býr servister filter o zmn Infrastructure de olusturcaz içinde bý class olsuturup classý IAsyncActionFilter dan turetcez 
/*
  if(!context.ModelState.IsValid) => hata var ýse 
            {
                var eror=context.ModelState   =>hatalarý al dýk 
                    .Where(x => x.Value.Errors.Any())  =>degerý eror olanlarý sectýk 
                    .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e =>e.ErrorMessage)).ToArray(); =>ToDictionary turunden key value seklýnde erorlarýn mesajýný cektýk array e attýk 

                context.Result=new BadRequestObjectResult(eror); //gerýye dondurduk 
            }
            await next();   =>burasý bý sonraký fýltera bakar 
 */

//sonra burasý bý servýs oldugu ýcýn eklemek lazým builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>()) bunun eklenmesý gerek

#endregion