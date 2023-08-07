using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Models.Queries.GetListByDynamic;

public class GetListByDynamicDto
{
    public Guid Id { get; set; }
    public string BrandName { get; set; }
    public string FuelName { get; set; }
    public string TransmissionName { get; set; }
    public string Name { get; set; }
    public decimal DailPrice { get; set; }
    public string ImageUrl { get; set; }
}
