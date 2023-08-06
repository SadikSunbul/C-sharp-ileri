using Application.Features.Brands.Rules;
using AutoMapper;
using AutoMapper.Internal;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Command.Create;

internal class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest, CreateCarCommandRespons>
{
    private readonly IMapper mapper;
    private readonly ICarRepository carRepository;
    private readonly BrandBusinessRules brandBusinessRules;
    public CreateCarCommandHandler(IMapper mapper, ICarRepository carRepository, BrandBusinessRules brandBusinessRules)
    {
        this.mapper = mapper;
        this.carRepository = carRepository;
        this.brandBusinessRules = brandBusinessRules;
    }

    public async Task<CreateCarCommandRespons> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
    {
        await brandBusinessRules.BrandNameConnotBeDuplicatedWhenInserted(request.Marka);

        Car? car = mapper.Map<Car>(request);
        await carRepository.AddAsync(car);
        CreateCarCommandRespons respons = mapper.Map<CreateCarCommandRespons>(car);
        return respons;
    }
}
