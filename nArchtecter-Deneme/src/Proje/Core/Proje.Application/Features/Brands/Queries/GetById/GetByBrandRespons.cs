using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Queries.GetById;

public class GetByBrandRespons
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdateDate { get; set; } //ilk olusturulurken gırılmek orunda olmadıgı ıcın ? verdık 
    public DateTime? DeletedDate { get; set; }
}
