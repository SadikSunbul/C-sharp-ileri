using AutoMapper;
using MediatR;
using Proje.Application.Features.Cars.Queries.GetList;
using Proje.Application.Services.Repository;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetById;

public class GetDynamicListCarHandler : IRequestHandler<GetDynamicListCarRequest, GetListRespons<GetDynamicListCarDto>>
{
    private readonly IMapper mapper;
    private readonly ICarRepository carRepository;

    public GetDynamicListCarHandler(IMapper mapper, ICarRepository carRepository)
    {
        this.mapper = mapper;
        this.carRepository = carRepository;
    }

    

    async Task<GetListRespons<GetDynamicListCarDto>> IRequestHandler<GetDynamicListCarRequest, GetListRespons<GetDynamicListCarDto>>.Handle(GetDynamicListCarRequest request, CancellationToken cancellationToken)
    {
        Paginate<Car>? pageCar = await carRepository.GetListByDynamic(
           dynamic: request.dynamicQuery,
           index: request.PageRequest.PageIndex,
           size: request.PageRequest.PageSize,
           cancellationToken: cancellationToken);



        GetListRespons<GetDynamicListCarDto> respons = mapper.Map<GetListRespons<GetDynamicListCarDto>>(pageCar);
        return respons;
    }
}
