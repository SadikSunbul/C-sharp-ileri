using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class ValidationProblemDetails:ProblemDetails
    {
        public IEnumerable<ValidationExceptionModel> Erors { get; set; }

        /// <summary>
        /// Fluent valıdatın ıcın hata yapılandırılması
        /// </summary>
        /// <param name="errors"></param>
        public ValidationProblemDetails(IEnumerable<ValidationExceptionModel> errors)
        {
            Title = "Rule Vialation";
            Detail = "One or more validation erorrs occurred";
            Erors = errors;
            Status = StatusCodes.Status400BadRequest;
            Type = "http://excample.com/problem/validation";
        }
    }
}
