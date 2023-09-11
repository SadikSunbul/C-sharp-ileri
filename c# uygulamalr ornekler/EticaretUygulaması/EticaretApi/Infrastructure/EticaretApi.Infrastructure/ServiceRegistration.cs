using EticaretApi.Application.Abstractions;
using EticaretApi.Application.Abstractions.Storage;
using EticaretApi.Application.Abstractions.Storage.Azure;
using EticaretApi.Application.Abstractions.Storage.Local;
using EticaretApi.Application.Services;
using EticaretApi.Infrastructure.Enums;
using EticaretApi.Infrastructure.Services;
using EticaretApi.Infrastructure.Services.Stogare;
using EticaretApi.Infrastructure.Services.Stogare.Azure;
using EticaretApi.Infrastructure.Services.Stogare.Local;
using EticaretApi.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
