using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Dynamic
{
    /// <summary>
    /// Dınamık sorgu için alınacak bilgileri içeriri
    /// </summary>
    public class DynamicQuery
    {
        public IEnumerable<Sort>? Sort { get; set; } //sıralama bilgileri
        public Filter? Filter { get; set; } //filtreleme bilgilerini içerir
        public DynamicQuery()
        {

        }
        public DynamicQuery(IEnumerable<Sort>? sort, Filter? filter)
        {
            Filter = filter;
            Sort = sort;
        }
    }
}
