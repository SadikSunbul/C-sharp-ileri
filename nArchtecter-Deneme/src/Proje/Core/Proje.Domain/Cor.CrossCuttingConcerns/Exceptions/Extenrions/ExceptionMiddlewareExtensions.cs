using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Extenrions;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app) => app.UseMiddleware<ExceptionMidlerware>();
}
