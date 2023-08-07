using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Delete;

public class DeleteBrandCommandRequest: IRequest<DeleteBrandCommandRespons>
{
    public Guid Id { get; set; }
}
