using EticaretApi.Application.Abstractions.Storage;
using EticaretApi.Application.Features.Queries._Product.GetAllProduct;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application
{
    public static class ServiceRegistration
    {
        public static void AddAplicationService(this IServiceCollection services)
        {
            //collection.AddMediatR(Assembly.GetAssembly()); //bu name spcae altındakı hepsını bulup kendısı entegre edıyor kutuphane hatakı ondan manuel eklıycem 

            services.AddMediatR(typeof(GetAllProductQueryRequest));
            services.AddHttpClient();
        }


    }
}
