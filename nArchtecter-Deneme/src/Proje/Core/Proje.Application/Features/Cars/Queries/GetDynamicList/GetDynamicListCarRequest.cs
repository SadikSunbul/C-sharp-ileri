using MediatR;
using Proje.Application.Features.Cars.Queries.GetList;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Dynamic;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetById;

public class GetDynamicListCarRequest : IRequest<GetListRespons<GetDynamicListCarDto>>
{
    public PageRequest PageRequest { get; set; }
    public DynamicQuery dynamicQuery { get; set; }
}
