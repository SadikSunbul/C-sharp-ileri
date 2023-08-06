using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class BusinessProblemDetails : ProblemDetails
{
    //ozel alanalr ekleye bılmek ıcın boyle yaptık 
    public BusinessProblemDetails(string detail)
    {
        Title = "Rule Vialation";
        Detail = detail;
        Status = StatusCodes.Status400BadRequest;
        Type = "http://excample.com/problem/business";
    }
}
