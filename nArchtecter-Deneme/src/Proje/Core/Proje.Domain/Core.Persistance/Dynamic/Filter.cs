using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Dynamic
{
    /// <summary>
    /// filtreleme işlemi için gereklı bilgıleri alır 
    /// </summary>
    public class Filter
    {
        public string Field { get; set; } //neye gore bır fıltreleme yapıcak 
        public string? Value { get; set; } //aranacak vb deger 
        public string? Operator { get; set; } //içinde gecen eşittir vb.
        public string? Logic { get; set; }//1 den fazla alanda calısma yapıcaz and or sart saglama durumları altakı ıle baglantı kurarken kullanılacak 

        public IEnumerable<Filter>? Filters { get; set; }  //filtre içinde filtre gibi
        public Filter()
        {
            Filters = new List<Filter>();
            Operator = string.Empty;
        }
        public Filter(string field, string @operator)
        {
            field = field;
            Operator = @operator;
        }
    }
}
