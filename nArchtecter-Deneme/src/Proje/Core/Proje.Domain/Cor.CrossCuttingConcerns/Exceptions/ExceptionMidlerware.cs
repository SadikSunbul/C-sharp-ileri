using Microsoft.AspNetCore.Http;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Handlers;
using Proje.Domain.Cor.CrossCuttingConcerns.Logging;
using Proje.Domain.Cor.CrossCuttingConcerns.SeriLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions;

public class ExceptionMidlerware
{
    private readonly RequestDelegate _next;
    private readonly HttpExceptionHandler _httpExceptionHandler;
    private readonly IHttpContextAccessor httpContextAccessor;
    private readonly LoggerServiceBase logger;
    public ExceptionMidlerware(RequestDelegate next, IHttpContextAccessor httpContextAccessor, LoggerServiceBase logger)
    {
        _next = next;
        _httpExceptionHandler = new HttpExceptionHandler(); //1 tane cunkı burası oyuzden drekt newledık 
        this.httpContextAccessor = httpContextAccessor;
        this.logger = logger;
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
            await LogExcption(context, ex);
            await HandlerExceptionAsync(context.Response, ex);
        }
    }

    private Task LogExcption(HttpContext context, Exception ex)
    {
        List<LogParameter> logParameters = new List<LogParameter>()
        {
            new LogParameter(){ Type=context.GetType().Name,
            Value=ex.ToString()},
        };

        //hATA ICIN URETTIGIMIZ SINIF
        LogDetailWithException logDetail = new()
        {
            MethotName = _next.Method.Name,
            Parameters = logParameters,
            User = httpContextAccessor.HttpContext?.User.Identity?.Name ?? "?",
            ExceptionMessage = ex.Message
        };

        logger.Error(JsonSerializer.Serialize(logDetail));
        return Task.CompletedTask;//ASENKRON DONME 
    }

    private Task HandlerExceptionAsync(HttpResponse response, Exception ex)
    {
        response.ContentType = "application/json";
        _httpExceptionHandler.Response = response;
        return _httpExceptionHandler.HandlerExceptionAsync(ex);
    }
}
