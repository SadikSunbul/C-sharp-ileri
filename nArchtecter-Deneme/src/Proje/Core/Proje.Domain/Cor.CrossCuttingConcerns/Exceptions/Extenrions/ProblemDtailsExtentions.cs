using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Extenrions;

public static class ProblemDtailsExtentions
{
    public static string AsJson<TProblemDetail>(this TProblemDetail detail)
        where TProblemDetail : ProblemDetails => JsonSerializer.Serialize(detail);
}
