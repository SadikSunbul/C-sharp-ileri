using Microsoft.EntityFrameworkCore;
using EticaretApi.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EticaretApi.Persistence.Repositories;
using EticaretApi.Application.Repositories;
using EticaretApi.Persistence.Repositories._File;
using EticaretApi.Persistence.Repositories._InvoiceFile;
using EticaretApi.Persistence.Repositories._ProductImageFile;
using EticaretApi.Domain.Entities._Identity;

namespace EticaretApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EticaretApiDbContext>(options => options.UseSqlServer(Configration.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(options =>  {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric=false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                
            }).AddEntityFrameworkStores<EticaretApiDbContext>();//AddIdentity daır tum stores lerımı EticaretApiDbContext bunda yap demeıs olduk 

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>(); //ICustomerReadRepository ıstenınce CustomerReadRepository döner
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IFileReadRepository,FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageWriteRepository, ProductImageFileWriteRepository>();

        }
    }
}
