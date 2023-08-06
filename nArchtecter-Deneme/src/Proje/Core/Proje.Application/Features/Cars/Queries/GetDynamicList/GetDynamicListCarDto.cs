using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Queries.GetById;

public class GetDynamicListCarDto
{
    public Guid Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public DateTime CreatedDate { get; set; }
}
