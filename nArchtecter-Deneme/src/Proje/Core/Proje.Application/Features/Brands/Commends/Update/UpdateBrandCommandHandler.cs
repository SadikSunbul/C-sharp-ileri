using AutoMapper;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Update;

public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, UpdateBrandCommandRespons>
{
    private readonly IMapper _mapper;
    private readonly IBrandRepository brandRepository;

    public UpdateBrandCommandHandler(IMapper mapper, IBrandRepository brandRepository)
    {
        _mapper = mapper;
        this.brandRepository = brandRepository;
    }

    public async Task<UpdateBrandCommandRespons> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        Brand? brand = await brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

        brand = _mapper.Map<Brand>(request);

        await brandRepository.UpdateAsync(brand);
        UpdateBrandCommandRespons response = _mapper.Map<UpdateBrandCommandRespons>(brand);
        return response;
    }
}
