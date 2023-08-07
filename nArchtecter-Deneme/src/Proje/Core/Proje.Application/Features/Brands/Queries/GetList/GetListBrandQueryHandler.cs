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

namespace Proje.Application.Features.Brands.Queries.GetList;

public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQueryRequest, GetListRespons<GetListBrandListItemDto>>
{
    private readonly IBrandRepository brandRepository;
    private readonly IMapper mapper;

    public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        this.brandRepository = brandRepository;
        this.mapper = mapper;
    }
    public async Task<GetListRespons<GetListBrandListItemDto>> Handle(GetListBrandQueryRequest request, CancellationToken cancellationToken)
    {
        Paginate<Brand?> brands = await brandRepository.GetListAsync(
                 index: request.PageRequest.PageIndex,
                 size: request.PageRequest.PageSize,
                 cancellationToken: cancellationToken
                 );

        GetListRespons<GetListBrandListItemDto> respons = mapper.Map<GetListRespons<GetListBrandListItemDto>>(brands);
        return respons;
    }
}
