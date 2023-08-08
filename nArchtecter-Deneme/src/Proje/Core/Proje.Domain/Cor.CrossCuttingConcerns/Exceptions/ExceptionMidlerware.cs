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
        _httpExceptionHandler = new HttpExceptionHandler(); //1 tane cunkı burası oyuzden drekt newledık 
    }
    //tek trycach ıle uygulamanın tamamı buradan gecsın 
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context); //apıden gelen ıstegı bır sonrakı ne gecer calıstır
        }
        catch (Exception ex) //hata durumunda buraya gırer 
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
