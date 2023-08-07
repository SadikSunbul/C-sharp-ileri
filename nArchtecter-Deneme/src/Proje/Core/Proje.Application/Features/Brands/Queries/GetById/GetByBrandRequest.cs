using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetById;

public class GetByBrandRequest:IRequest<GetByBrandRespons>
{
    public Guid Id { get; set; }
}
