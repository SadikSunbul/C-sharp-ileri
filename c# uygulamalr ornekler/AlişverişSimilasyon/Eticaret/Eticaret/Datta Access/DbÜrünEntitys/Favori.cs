using Eticaret.Datta_Access.DbGirişEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbÜrünEntitys
{
    public class Favori
    {
        public int kullanıcıId { get; set; }
        public int ürünId { get; set; }
        public NkKullanıcı NkKullanıcı { get; set; }
        public Ürün ürün { get; set; }
    }
}
