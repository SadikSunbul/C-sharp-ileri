using Eticaret.Datta_Access.DbGirişEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbÜrünEntitys
{
    public class Sepet
    {
        public int KullanıcıId { get; set; }
        public int ÜrünId { get; set; }
        public Ürün ürün { get; set; }
        public NkKullanıcı NkKullanıcı { get; set; }
    }
}
