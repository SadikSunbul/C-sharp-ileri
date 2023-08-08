using AutoMapper;
using Proje.Application.Features.Brands.Commends.Create;
using Proje.Application.Features.Brands.Commends.Delete;
using Proje.Application.Features.Brands.Commends.Update;
using Proje.Application.Features.Brands.Queries.GetById;
using Proje.Application.Features.Brands.Queries.GetList;
using Proje.Application.Features.Brands.Queries.GetListByDynamic;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Core.Persistance.Repositories;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreateBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, CreateBrandCommandRespons>().ReverseMap();

            CreateMap<Brand, DeleteBrandCommandRespons>().ReverseMap();

            CreateMap<Brand, UpdateBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommandRespons>().ReverseMap();

            CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
            CreateMap<GetListRespons<GetListBrandListItemDto>, Paginate<Brand>>().ReverseMap();

            CreateMap<GetByBrandRespons, Brand>().ReverseMap();


            CreateMap<GetListByDynamicBrandQueriesDto, Brand>().ReverseMap();
            CreateMap<GetListRespons<GetListByDynamicBrandQueriesDto>, Paginate<Brand>>().ReverseMap();

        }
    }
}
