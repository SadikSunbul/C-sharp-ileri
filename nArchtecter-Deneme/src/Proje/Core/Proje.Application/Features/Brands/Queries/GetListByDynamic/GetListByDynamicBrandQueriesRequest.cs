using MediatR;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetListByDynamic;

public class GetListByDynamicBrandQueriesRequest:IRequest<GetListRespons<GetListByDynamicBrandQueriesDto>>
{
    public PageRequest PageRequest { get; set; }
    public DynamicQuery dynamicQuery { get; set; }
}
