using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.RequestParameters
{
    public record Pagination
    {
        //verılerın hepsını ıstekte gondermeyız parca parca gonderırız onun ıcın karsıdan alınacak verı ıcın olusturulmus bır sınıf
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
