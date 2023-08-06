using Microsoft.AspNetCore.Http;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions;

public class ExceptionMidlerware
{
    private readonly RequestDelegate _next;
    private readonly HttpExceptionHandler _httpExceptionHandler;

    public ExceptionMidlerware(RequestDelegate next)
    {
        _next = next;
        _httpExceptionHandler = new HttpExceptionHandler();
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context); //apıden gelen ıstegı calıstır
        }
        catch (Exception ex)
        {
            await HandlerExceptionAsync(context.Response, ex);
        }
    }

    private Task HandlerExceptionAsync(HttpResponse response, Exception ex)
    {
        response.ContentType = "application/json";
        _httpExceptionHandler.Response = response;
        return _httpExceptionHandler.HandlerExceptionAsync(ex);
    }
}
