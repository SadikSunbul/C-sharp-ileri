using MediatR;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetList
{
    public class GetListCaQueryRequest:IRequest<GetListRespons<GetListCaQueryDto>>
    {
        public PageRequest PageRequest { get; set; }//sayfalama ıcın gereklı bılgılerı alıcak 
    }
}
