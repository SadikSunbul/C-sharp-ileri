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
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public RequestValidaterBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TRespons> Handle(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {
        ValidationContext<object> context = new(request);

        IEnumerable<ValidationExceptionModel> errors = _validators.Select(v => v.Validate(context))
            .SelectMany(result => result.Errors)
            .Where(failure => failure != null)
            .GroupBy(keySelector: p => p.PropertyName,
            resultSelector: (propertyName, errors) =>
            new ValidationExceptionModel { Property = propertyName, Errors = errors.Select(E => E.ErrorMessage) }).ToList();
        if (errors.Any())
        {//hat var ıse fırlat 
            throw new ValidationException(errors);
        }
        TRespons respons = await next(); //hata yok ıse gec
        return respons;
    }
}
