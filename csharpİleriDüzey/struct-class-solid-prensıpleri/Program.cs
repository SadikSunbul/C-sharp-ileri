

#region Struct ve Class arasındakı farklar

//stract value typ  class referans typ
//structlar null olamz cunkı deger tıplıdir
//structın parametresız bır ctoru olamaz dı artık c# 10 ıle olabılıryor
//structa default degerlerının verılmesı gererkır bız ezdıysek onu kendımızın yazmamız lazım 
//structı bvı yere parametre olarak gonderıncde deger olarak kopyalanıyor o yuzden ıcerıdekı degısıklıklerden etkılenmıyor
//classlar boyle degıl referans tıplı oldukları ıcın aynı yerı tutar degısıklık olur 
//bır klasın ıcerısıne bı clası propery olarak eklıyebılrırz
//Inline lar sadece classlarda olur  Inline--> clas ıcerısınde clas demek
//stracta kendını tutamaz ama baska bır strac ı tutabılır

/*
static void Adingments()
{
    int x = 1;  //deger tıp 
    int y = x;

    x = 10;

    var user = new UserClass();  //referans tıp
    user.Id = 1;

    var userc1 = user;
    userc1.Id = 10;

    Console.WriteLine(y); //y burada 1
    Console.WriteLine(userc1.Id);//buradakı deger 10 dur 
}

 static  void InterFacelermentation()
{
    IUser user = new UserClass();
    user.Id = 1;
    IUser user1 = user;
    user1.Id = 10;

    Console.WriteLine(user1.Id); //10 yazar

    IUser user2 = new Userstruct1();
    user2.Id = 1;
    IUser user3 = user;
    user3.Id = 10;

    Console.WriteLine(user2.Id); //burada tam tersı olucaktır cunkı burası deger tıplı deger lı oldugu ıcın ılkının degrı aynı kalıcaktı ama burada ınterface uzerınden gıdıldıgı ızın Userstruct1:IUser referans gıbı hareket edıcek ve 10 degerını getırcektır

}

class UserClass:IUser
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public UserClass InlineUserClass { get; set; }
}
 struct Userstruct1:IUser
{
    public Userstruct1() //default degerler yZILMAZSA HATA VERICEKTIR 
    {
        Id = 0;
        FullName = string.Empty;
    }
    public int Id { get; set; }
    public string FullName { get; set; }

}

public interface IUser
{
    public int Id { get; set; }
    public string FullName { get; set; }
}

#endregion

#region Solid Prensipleri

/*
    S ->(Single Responsibility Principle - Tek Sorumluluk Prensibi): Bir sınıfın sadece bir sorumluluğu olmalıdır. Bu, sınıfların, işlevleriyle ilgili sadece bir tür bilgiyi içermesi gerektiği anlamına gelir.
    O -> (Open/Closed Principle - Açık/Kapalı Prensibi): Sisteme yeni özellikler eklenebilir olmalı, ancak mevcut kod değiştirilmemelidir. Bu prensip, yazılımın esnekliğini ve genişletilebilirliğini arttırmaya yardımcı olur.
    L ->(Liskov Substitution Principle - Liskov Yerine Koyma Prensibi): Alt sınıflar, üst sınıfların yerine kullanılabilmelidir. Bu, bir üst sınıfın tüm özelliklerinin, alt sınıflarda da geçerli olması gerektiği anlamına gelir.
    I ->(Interface Segregation Principle - Arayüz Ayrımı Prensibi): Sınıflar, kullanmayacakları arayüzleri uygulamamalıdır. Bu, gereksiz bağımlılıkları önleyerek, daha sade ve okunaklı kod yazmaya yardımcı olur.
    D -> (Dependency Inversion Principle - Bağımlılık Tersine Çevirme Prensibi): Sınıflar, somut sınıflara değil, soyutlara (örneğin, arayüzler) bağımlı olmalıdır. Bu, yazılımın daha kolay test edilmesini ve değiştirilmesini sağlar.
 */

/*
     S ->(SRP)
 
     O ->(OCP)
 
     L ->(LSP)
 
     I ->(ISP)
 
     D ->(DIP)
 */



*/
void a()
{

}

a();


#endregion