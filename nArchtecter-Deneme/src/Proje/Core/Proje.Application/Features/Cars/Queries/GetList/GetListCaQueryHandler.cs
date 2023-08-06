﻿using AutoMapper;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetList
{
    public class GetListCaQueryHandler : IRequestHandler<GetListCaQueryRequest, GetListRespons<GetListCaQueryDto>>
    {
        private readonly IMapper mapper;
        private readonly ICarRepository carRepository;

        public GetListCaQueryHandler(IMapper mapper, ICarRepository carRepository)
        {
            this.mapper = mapper;
            this.carRepository = carRepository;
        }

        public async Task<GetListRespons<GetListCaQueryDto>> Handle(GetListCaQueryRequest request, CancellationToken cancellationToken)
        {
            Paginate<Car>? data = await carRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            GetListRespons<GetListCaQueryDto> respons = mapper.Map<GetListRespons<GetListCaQueryDto>>(data);
            return respons;
        }

    }
}
