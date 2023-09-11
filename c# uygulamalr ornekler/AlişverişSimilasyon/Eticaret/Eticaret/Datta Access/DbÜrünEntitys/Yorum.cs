using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbÜrünEntitys
{
    public class Yorum
    {
        public int Id { get; set; }
        public string Yorumm { get; set; }
        public DateTime YorumAtılmaZamanı { get;private set; }
        public Ürün Ürün { get; set; }
    }
}
