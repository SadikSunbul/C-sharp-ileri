using AutoMapper;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetById;

public class GetByBrandHandler : IRequestHandler<GetByBrandRequest, GetByBrandRespons>
{
    private readonly IMapper mapper;
    private readonly IBrandRepository brandRepository;

    public GetByBrandHandler(IMapper mapper, IBrandRepository brandRepository)
    {
        this.mapper = mapper;
        this.brandRepository = brandRepository;
    }
    public async Task<GetByBrandRespons> Handle(GetByBrandRequest request, CancellationToken cancellationToken)
    {
        Brand? brand = await brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);
        //burada wıthDeleted false dersen sılınenıde getırı 
        GetByBrandRespons respons = mapper.Map<GetByBrandRespons>(brand);
        return respons;
    }
}
