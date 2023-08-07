using MediatR;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetList;

public class GetListBrandQueryRequest:IRequest<GetListRespons<GetListBrandListItemDto>>
{
    public PageRequest PageRequest { get; set; }
}
