using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Proje.Application.Services.Repository;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Models.Queries.GetListByDynamic;

public class GetListByDynamicHandler : IRequestHandler<GetListByDynamicRequest, GetListRespons<GetListByDynamicDto>>
{
    private readonly IMapper mapper;
    private readonly IModelRepository modelRepository;

    public GetListByDynamicHandler(IMapper mapper, IModelRepository modelRepository)
    {
        this.mapper = mapper;
        this.modelRepository = modelRepository;
    }

    public async Task<GetListRespons<GetListByDynamicDto>> Handle(GetListByDynamicRequest request, CancellationToken cancellationToken)
    {
        Paginate<Model> models = await modelRepository.GetListByDynamic(
                dynamic: request.dynamicQuery,
                  include: m => m.Include(m => m.Brand).Include(m => m.Fuel).Include(m => m.Transmission),
                  index: request.PageRequest.PageIndex,
                  size: request.PageRequest.PageSize,
                  cancellationToken: cancellationToken
                  );

        var respons = mapper.Map<GetListRespons<GetListByDynamicDto>>(models);
        return respons;
    }
}
