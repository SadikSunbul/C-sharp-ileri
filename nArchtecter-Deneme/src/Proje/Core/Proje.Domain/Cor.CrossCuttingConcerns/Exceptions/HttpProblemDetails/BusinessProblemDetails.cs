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
    /// <summary>
    /// İş katmanı hatası için özel hata mesajı üretiliyor
    /// </summary>
    /// <param name="detail"></param>
    public BusinessProblemDetails(string detail)
    {
        Title = "Rule Vialation";
        Detail = detail;
        Status = StatusCodes.Status400BadRequest;
        Type = "http://excample.com/problem/business";
    }

    /*
     Bu tür bir yapı, API istekleri sırasında oluşan hataları yönetmek, istemcilere daha anlamlı ve özelleştirilmiş hata yanıtları sağlamak için kullanılır. Özellikle API'nin kullanıcı dostu olması ve hataların anlaşılabilir şekilde raporlanması açısından önemlidir.
     */
}
