using Eticaret.Datta_Access.DbÜrünEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbGirişEntitys
{
    public class Satıcı:Kişi
    {
        public Satıcı()
        {
            ürünler = new HashSet<Ürün>();
        }
        public string ŞirketAdı { get; set; }
        public string Adress { get; set; }
        public ICollection<Ürün> ürünler { get; set; }
    }
}
