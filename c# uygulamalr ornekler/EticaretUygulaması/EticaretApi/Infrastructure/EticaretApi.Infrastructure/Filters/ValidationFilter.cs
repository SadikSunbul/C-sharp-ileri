using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(!context.ModelState.IsValid)
            {
                var eror=context.ModelState
                    .Where(x => x.Value.Errors.Any())
                    .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e =>e.ErrorMessage)).ToArray();

                context.Result=new BadRequestObjectResult(eror);
            }
            await next();
        }
    }
}
