using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetById;

public class GetDynamicListCarRespons
{

    public List<dto> items { get; set; }
}

public class dto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}
