using OrnekVebSitesi.Models.EfCore.Entities;

namespace OrnekVebSitesi.Models.ViewModel
{
    public class KullanıcıKaytViewModel
    {
        public string İsimSoyiism { get; set; }
        public string Email { get; set; }
        public string Şifere1 { get; set; }
        public string Şifere2 { get; set; }


        public static implicit operator KullanıcıKaytViewModel(Kullanıcı kullanıcı)
        {
            return new KullanıcıKaytViewModel{ 
            İsimSoyiism=kullanıcı.İsimSoyiism,
             Email=kullanıcı.Email,
              Şifere1=kullanıcı.Şifre
            };
        }

        public static implicit operator Kullanıcı(KullanıcıKaytViewModel kullanıcı)
        {
            return new Kullanıcı
            {
                İsimSoyiism = kullanıcı.İsimSoyiism,
                Email = kullanıcı.Email,
                Şifre = kullanıcı.Şifere1
            };
        }
    }
}
