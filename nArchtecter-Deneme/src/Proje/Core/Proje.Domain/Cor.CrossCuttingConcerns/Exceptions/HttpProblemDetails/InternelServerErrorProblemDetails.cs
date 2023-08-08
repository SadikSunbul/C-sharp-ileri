using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class InternelServerErrorProblemDetails : ProblemDetails
{
    //ozel alanalr ekleye bılmek ıcın boyle yaptık 
    /// <summary>
    /// Bılınmeyen bır hata ıcın server hatasını yapılandırız
    /// </summary>
    /// <param name="detail"></param>
    public InternelServerErrorProblemDetails(string detail)
    {
        Title = "Internal server error";
        Detail = "Internal server error";
        Status = StatusCodes.Status500InternalServerError;
        Type = "http://excample.com/problem/internal";
    }
}
