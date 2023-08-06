using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetList
{
    public class GetListCaQueryDto
    {
        public Guid Id { get; set; }
        public string CarMarka { get; set; }
        public string CarModel { get; set; }
    }

}
