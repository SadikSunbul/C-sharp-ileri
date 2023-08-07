using AutoMapper;
using Proje.Application.Features.Models.Queries.GetList;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Paging;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<GetListRespons<GetListModelListItemDto>, Paginate<Model>>().ReverseMap();
        CreateMap<Model, GetListModelListItemDto>().ReverseMap();

        //problem burada name = Model.Brand.Name eşleşmez bunun eşleşmesi için üsteki kodlar eklenmelidir

        //Üsteki seneryo genelde isim benzerliği olmıyan yerler için veri karsılıgını belirtmek için kullanılır

        // BrandName=Model.Brand.Name yi işleştirir

        CreateMap<Model, GetListModelListItemDto>().ReverseMap();
        CreateMap<Paginate<Model>, GetListRespons<GetListModelListItemDto>>().ReverseMap();


    }
}
