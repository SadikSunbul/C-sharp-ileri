using Eticaret.Datta_Access.DbGirişEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Datta_Access.DbÜrünEntitys
{
    public class Ürün
    {
        public Ürün()
        {
            Fvorikullanıcılar = new HashSet<Favori>();
            sepetkullanıcılar=new HashSet<Sepet>();
            Yorumlar = new HashSet<Yorum>();
        }
        public int Id { get; set; }
        public string ÜrünAdı { get; set; }
        public string Acıklama { get; set; }
        public int Fiyat { get; set; } = 0;
        public int Beğenisayısı { get; set; } = 0;
        public int SatısSayısı { get; set; } = 0; 
        public Satıcı satıcı { get; set; }

        //yorumlar baglanılıcak
        public ICollection<Favori> Fvorikullanıcılar { get; set; }
        public ICollection<Sepet> sepetkullanıcılar { get; set; }
        public ICollection<Yorum> Yorumlar { get; set; }
    }
}
