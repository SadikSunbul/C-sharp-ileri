using MediatR;
using Microsoft.AspNetCore.Http;
using Proje.Domain.Cor.CrossCuttingConcerns.Logging;
using Proje.Domain.Cor.CrossCuttingConcerns.SeriLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Applicatioın.PipeLines.Logging;

public class LogginBehavior<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons> where TRequest : IRequest<TRespons>, ILoggableRequest
{
    private readonly IHttpContextAccessor httpContextAccessor;//kım olusturdu bunu kullanıcı bılgılerı
    private readonly LoggerServiceBase loggerServiceBase;

    public LogginBehavior(IHttpContextAccessor httpContextAccessor, LoggerServiceBase loggerServiceBase)
    {
        this.httpContextAccessor = httpContextAccessor;
        this.loggerServiceBase = loggerServiceBase;
    }

    public async Task<TRespons> Handle(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {
       List<LogParameter> logParameters=
            new List<LogParameter>()
            {
                new LogParameter{Type=request.GetType().Name,
                Value=request},
            };
        LogDetail logDetail= new LogDetail()
        {
            MethotName=next.Method.Name,
            Parameters=logParameters,
            User=httpContextAccessor.HttpContext.User.Identity?.Name??"?"
        };

        loggerServiceBase.Information(JsonSerializer.Serialize(logDetail));
        return await next();
    }
}
