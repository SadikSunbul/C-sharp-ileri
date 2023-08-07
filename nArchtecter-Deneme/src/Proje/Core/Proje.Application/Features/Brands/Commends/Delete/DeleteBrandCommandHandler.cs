using AutoMapper;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Delete;

public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest, DeleteBrandCommandRespons>
{
    private readonly IBrandRepository brandRepository;
    private readonly IMapper mapper;

    public DeleteBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        this.brandRepository = brandRepository;
        this.mapper = mapper;
    }
    public async Task<DeleteBrandCommandRespons> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
    {
        Brand? brand = await brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

        await brandRepository.DeleteAsync(brand);
        DeleteBrandCommandRespons respons = mapper.Map<DeleteBrandCommandRespons>(brand);
        return respons;
    }
}
