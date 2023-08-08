using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Routing;
using Proje.Application.Features.Brands.Rules;
using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Create;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandRespons>
{
    private readonly IMapper mapper;
    private readonly IBrandRepository brandRepository;
    private readonly BrandBusinessRules brandBusinessRules;


    public CreateBrandCommandHandler(IMapper mapper, IBrandRepository brandRepository, BrandBusinessRules brandBusinessRules)
    {
        this.mapper = mapper;
        this.brandRepository = brandRepository;
        this.brandBusinessRules = brandBusinessRules;
    }

    public async Task<CreateBrandCommandRespons> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        await brandBusinessRules.BrandNameConnotBeDuplicatedWhenInserted(request.Name);//iş kuralını böyle kullandık ve try cache kullanımını azalttık problem cıkarsa hata yı fırlatıcaktır

        Brand brand = mapper.Map<Brand>(request);
        brand.Id = Guid.NewGuid();

        await brandRepository.AddAsync(brand); //bu basarılı oldu 
        // await brandRepository.AddAsync(brand); //bu basarısız oldu ıse ilkının ıslemı gerı alınmalıdır 

        CreateBrandCommandRespons respons = mapper.Map<CreateBrandCommandRespons>(brand);
        return respons;
    }
}
