using MediatR;
using Proje.Domain.Core.Applicatioın.PipeLines.Caching;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetList;

public class GetListBrandQueryRequest : IRequest<GetListRespons<GetListBrandListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string CacheKey => $"GetListBrandQueryRequest({PageRequest.PageIndex},{PageRequest.PageSize})";

    public bool BypassCache { get; }

    public TimeSpan? SlidiExpiration { get; }

    public string? CavheGroupKey => "GetBrands";//bu ısımde bır array tutcak 
}

//ICachableRequest bunu dedıgımızde artık bura cache yapısında olucaktır 