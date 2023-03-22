
/*
 Projeniz şunu yapacak.

Bir bankada müşteri takibi yapmak istiyorsunuz.
Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.

 */
using BankaMüşteriTakipSistemi;

int kontrol = 0;
do
{
    Console.Clear();
    Console.WriteLine("Ana menüye hoşgeldiniz");
    Console.WriteLine("1-> Giriş");
    Console.WriteLine("2-> Kayıt");
    Console.WriteLine("3-> Silme");
    Console.WriteLine("4-> kullanıcıların ismini Listeleme");
    Console.WriteLine("Lütfen birini seçiniz (sadece sayıyı yazınız ornek = 1 )");
    int seçim = int.Parse(Console.ReadLine()); //burada kuyllanıcın kılavyesınden bır sayı aldık 

    switch (seçim)
    {
        case 1:
            Console.WriteLine("Giriş sayfasına hoşgeldiniz:");
            Müşteri musteri = new();
            Console.WriteLine("Mail:");
            musteri.Email = Console.ReadLine();
            Console.WriteLine("şifre");
            musteri.Şifre = Console.ReadLine();

            MüşteriManager.giriş(musteri);
            break;
        case 2:
            Console.WriteLine("Kayıt sayfasına hosgeldınız:");
            Müşteri musteri1 = new();
            Console.WriteLine("İsim:");
            musteri1.İsim = Console.ReadLine();
            Console.WriteLine("soyisim:");
            musteri1.Soyisim = Console.ReadLine();
            Console.WriteLine("Mail:");
            musteri1.Email = Console.ReadLine();
            Console.WriteLine("şifre");
            musteri1.Şifre = Console.ReadLine();

            MüşteriManager.Ekle(musteri1);
            break;
        case 3:
            Console.WriteLine("Şilme sayfasına hoşgeldiniz:");
            Müşteri musteri2 = new();
            Console.WriteLine("Mail:");
            musteri2.Email = Console.ReadLine();
            Console.WriteLine("şifre");
            musteri2.Şifre = Console.ReadLine();

            MüşteriManager.sil(musteri2);
            break;
        case 4:
            Console.WriteLine(" kullanıcıların ismini Listeleme");
            for (int i = 0; i < MüşteriManager.database.Count; i++)//DATABASE KADAR DONDUK BURADA
            {
                Console.WriteLine(MüşteriManager.database[i].İsim);//i. databsedekı kaydın ısmını dondurucek burada bzıe
            }
            break;
        default:
            break;
    }

    Console.WriteLine("İşlemlere devam etmek ıstıyorsanız 1 yazınız ıstemıyorsanız herhangı bır sayı yazınız");

    kontrol = int.Parse(Console.ReadLine());

} while (kontrol == 1); //kontrol 1 ıse devam et 1 den farklı ıse cık 