using MediatR;
using Proje.Domain.Core.Applicatioın.PipeLines.Caching;
using Proje.Domain.Core.Applicatioın.PipeLines.Logging;
using Proje.Domain.Core.Applicatioın.PipeLines.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Create;

public class CreateBrandCommandRequest : IRequest<CreateBrandCommandRespons>, ITransactionalRequest, ICecheRemoverRequest,ILoggableRequest
{
    public string Name { get; set; }

    //burada cach anahtarı sabit değil aslında 
    public string CacheKey => "";

    public bool BypassCache => false;

    public string? CacheGroupKey => "GetBrands"; //SİLİNCEK CACHE LISTESI ekleme oldugunda cachler sılınmelıkı guncellensin
}

// ITransactionalRequest bu alt yapıyı olusturdugumuzda bızım ıcın bırden fazla ıslem sırasında herhangı bır hata cıkar ıse ıslemelrın gerı alınmasını saglıycaktır

//ICecheRemoverRequest silme işlemi cachiçunku burası calşır ise listelemede verı kaybı olur 
