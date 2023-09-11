using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Restorant.Application.Repositorys._Basket;
using Restorant.Application.Repositorys._Custoemer;
using Restorant.Application.Repositorys._Food;
using Restorant.Application.Repositorys._Like;
using Restorant.Application.Repositorys._Order;
using Restorant.Application.Repositorys._Payment;
using Restorant.Application.Repositorys._Table;
using Restorant.Application.Repositorys._Worker;
using Restorant.Persistence.Context;
using Restorant.Persistence.Repositorys._Basket;
using Restorant.Persistence.Repositorys._Customer;
using Restorant.Persistence.Repositorys._Food;
using Restorant.Persistence.Repositorys._Like;
using Restorant.Persistence.Repositorys._Order;
using Restorant.Persistence.Repositorys._Payment;
using Restorant.Persistence.Repositorys._Table;
using Restorant.Persistence.Repositorys._Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence
{
    public static class PersitenceService
    {
        public static void AddPersistanceService(this IServiceCollection services)
        {
            services.AddDbContext<RestorantDbContext>(options=>options.UseSqlServer(Connections.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IFoodReadRepository, FoodReadRepository>();
            services.AddScoped<IFoodWriteRepository, FoodWriteRepository>();

            services.AddScoped<ITableReadRepository,TableReadRepository >();
            services.AddScoped<ITableWriteRepository,TableWriteRepository>();

            services.AddScoped<IWorkerWriteRepository,WorkerWriteRepository>();
            services.AddScoped<IWorkerReadRepository,WorkerReadRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWiteRepository>();

            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();

            services.AddScoped<ILikeReadRepository, LikeReadRepository>();
            services.AddScoped<ILikeWriteRepository, LikeWriteRepository>();

			services.AddScoped<IPaymentReadRepository, PaymentReadRepository>();
			services.AddScoped<IPaymentWriteRepository, PaymentWriteRepository>();


		}
    }
}
