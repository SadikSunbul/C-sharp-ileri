using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationException = Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Type.ValidationException;

namespace Proje.Application.PipeLines.Validation;

public class RequestValidaterBehavior<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons> where TRequest : IRequest<TRespons> //MediatR
{
    //bır requestın valıdaterlarına ulasıcaz Abstractvalıdaer olanalra yanı ıoc ıle alıyoruz
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public RequestValidaterBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TRespons> Handle(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {
        
        ValidationContext<object> context = new(request);//using FluentValidation; ile gelir

        IEnumerable<ValidationExceptionModel> errors = _validators.Select(v => v.Validate(context)) //her bir validaterı secerek valid et context ıcın
            .SelectMany(result => result.Errors)//1 den fazla olabılır resultun errorlarını dondururyor
            .Where(failure => failure != null) //erorlar ıcın bır failur var ıse  ve bunları grup by yap
            .GroupBy(
            keySelector: p => p.PropertyName,
            resultSelector: (propertyName, errors) =>
            new ValidationExceptionModel { Property = propertyName, Errors = errors.Select(E => E.ErrorMessage) }).ToList();
        if (errors.Any())
        {//hat var ıse fırlat 
            throw new ValidationException(errors);
        }
        //midleware dıgerı ne gec kodu 
        TRespons respons = await next(); //hata yok ıse gec
        return respons;
    }
}
