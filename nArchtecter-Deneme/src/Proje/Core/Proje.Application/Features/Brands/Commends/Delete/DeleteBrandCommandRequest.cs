using MediatR;
using Proje.Domain.Core.Applicatioın.PipeLines.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Delete;

public class DeleteBrandCommandRequest: IRequest<DeleteBrandCommandRespons>, ICecheRemoverRequest
{
    public Guid Id { get; set; }
    public string CacheKey => "";

    public bool BypassCache => false;

    public string? CacheGroupKey => "GetBrands";
}
