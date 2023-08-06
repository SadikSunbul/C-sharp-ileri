using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetList
{
    public class GetListCaQueryRespons
    {
        public List<GetListCaQueryDto> items { get; set; }
        public PagedResult PagedResult { get; set; }
    }
}
