using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Update;

public class UpdateBrandCommandRequest:IRequest<UpdateBrandCommandRespons>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
