using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Create;

public class CreateBrandCommandRequest:IRequest<CreateBrandCommandRespons>
{
    public string Name { get; set; }
}
