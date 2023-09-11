using Eticaret.Datta_Access.DbÜrünEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbGirişEntitys
{
    public class NkKullanıcı:Kişi
    {
        public NkKullanıcı()
        {
            favoriürünler = new HashSet<Favori>();
            Sepetürünler = new HashSet<Sepet>();
        }
        public string Adress { get; set; }

        public ICollection<Favori> favoriürünler { get; set; }
        public ICollection<Sepet> Sepetürünler { get; set; }
    }
}
