using MediatR;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Models.Queries.GetList;

public class GetListModelListItemRequest:IRequest<GetListRespons<GetListModelListItemDto>>
{
    public PageRequest PageRequest { get; set; }
}
