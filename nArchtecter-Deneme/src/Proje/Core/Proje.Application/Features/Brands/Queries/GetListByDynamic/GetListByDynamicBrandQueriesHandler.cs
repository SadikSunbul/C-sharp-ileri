using AutoMapper;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetListByDynamic;

public class GetListByDynamicBrandQueriesHandler : IRequestHandler<GetListByDynamicBrandQueriesRequest, GetListRespons<GetListByDynamicBrandQueriesDto>>
{
    private readonly IMapper mapper;
    private readonly IBrandRepository brandRepository;

    public GetListByDynamicBrandQueriesHandler(IMapper mapper, IBrandRepository brandRepository)
    {
        this.mapper = mapper;
        this.brandRepository = brandRepository;
    }

    async Task<GetListRespons<GetListByDynamicBrandQueriesDto>> IRequestHandler<GetListByDynamicBrandQueriesRequest, GetListRespons<GetListByDynamicBrandQueriesDto>>.Handle(GetListByDynamicBrandQueriesRequest request, CancellationToken cancellationToken)
    {
        Paginate<Brand>? paginate = await brandRepository.GetListByDynamic(
            dynamic: request.dynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken);

        var respons = mapper.Map<GetListRespons<GetListByDynamicBrandQueriesDto>>(paginate);
        return respons;
    }
}
