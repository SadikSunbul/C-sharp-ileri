using Cor.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Extenrions;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Type;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationProblemDetails = Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.HttpProblemDetails.ValidationProblemDetails;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Handlers;

//ExceptionHandler dakılerın ıcerısını doldurur hata ların kodları mesajlar bruada yapılaırılır 
public class HttpExceptionHandler : ExceptionHandler
{
    private HttpResponse? response; //http gerı donus deger
    public HttpResponse Response
    {
        get => response ?? throw new ArgumentNullException(nameof(response)); //boş ise nul hatası dondur
        set => response = value;
    }

    protected override Task HandlerException(BusinessException businessException)
    {
        Response.StatusCode = StatusCodes.Status400BadRequest;
        string details = new BusinessProblemDetails(businessException.Message).AsJson();

        return Response.WriteAsync(details); //detayları ver
    }

    protected override Task HandlerException(Exception exception)
    {
        Response.StatusCode = StatusCodes.Status500InternalServerError;

        //ongoremedıgımız bır hata ıcın yazıldı 
        string details = new InternelServerErrorProblemDetails(exception.Message).AsJson();

        return Response.WriteAsync(details); //detayları ver
    }

    protected override Task HandlerException(ValidationException exception)
    {
        Response.StatusCode = StatusCodes.Status400BadRequest;
        string details = new ValidationProblemDetails(exception.Errors).AsJson();

        return Response.WriteAsync(details); //detayları ver
    }
}
