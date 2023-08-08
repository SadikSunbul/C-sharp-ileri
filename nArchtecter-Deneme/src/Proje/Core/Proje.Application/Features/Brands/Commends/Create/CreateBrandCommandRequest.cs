using MediatR;
using Proje.Domain.Core.Applicatioın.PipeLines.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Create;

public class CreateBrandCommandRequest:IRequest<CreateBrandCommandRespons>,ITransactionalRequest
{
    public string Name { get; set; }
}

// ITransactionalRequest bu alt yapıyı olusturdugumuzda bızım ıcın bırden fazla ıslem sırasında herhangı bır hata cıkar ıse ıslemelrın gerı alınmasını saglıycaktır
