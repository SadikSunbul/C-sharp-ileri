using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbGirişEntitys
{
    public class Kişi
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Mail { get; set; }
        public string Şifre { get; set; }
        public string Durum { get; set; } = "Normal";
    }
}
