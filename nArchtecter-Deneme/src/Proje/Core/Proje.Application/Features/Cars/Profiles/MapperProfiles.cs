using AutoMapper;
using Proje.Application.Features.Cars.Command.Create;
using Proje.Application.Features.Cars.Command.Delete;
using Proje.Application.Features.Cars.Queries.GetById;
using Proje.Application.Features.Cars.Queries.GetList;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Profiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Car, CreateCarCommandRequest>().ReverseMap();
            CreateMap<Car, CreateCarCommandRespons>().ReverseMap();

            CreateMap<Car, DeletedCarCommandRequest>().ReverseMap();
            CreateMap<Car, DeletedCarCommandRespons>().ReverseMap();

            CreateMap<Car, GetListCaQueryRequest>().ReverseMap();
            CreateMap<Car, GetListCaQueryDto>().ReverseMap();

            CreateMap<Paginate<Car>, GetListCaQueryDto>().ReverseMap();



            CreateMap<GetDynamicListCarRespons, Car>().ReverseMap();
            CreateMap<GetDynamicListCarRespons, PagedResult<Car>>().ReverseMap();

            CreateMap<GetListRespons<GetListCaQueryDto>, Paginate<Car>>().ReverseMap();

            


            CreateMap<GetListCaQueryRespons, Paginate<Car>>().ReverseMap();

        }

    }
}
