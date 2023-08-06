using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proje.Application.Services.Repository;
using Proje.Persistence.Context;
using Proje.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistence;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddPersistenceService(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<BaseContext>(config => config.UseInMemoryDatabase("nArchtecture"));

        services.AddDbContext<BaseContext>(cof => cof.UseSqlServer(configuration.GetConnectionString("mssql"))); 
        services.AddScoped<ICarRepository, CarRepositories>();
        return services;
    }
}
