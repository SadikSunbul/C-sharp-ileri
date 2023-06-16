using System;
using System.Security.Cryptography.X509Certificates;

namespace _2._0.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Memeli memeli = new();
            Maymun maymun = new Maymun();
            Orangutan orangutan = new Orangutan();
            İnek inek = new();

            memeli.Konus();
            maymun.Konus();
            orangutan.Konus();
            inek.Konus();

            Ucgen ucgen = new(3, 4);
            Console.WriteLine(ucgen.Alanhesapla());

            Dortgen dortgen = new(3, 4);
            Console.WriteLine(dortgen.Alanhesapla());

        }
    }

    #region Sanal Yapılar | virtual - override
    /*
     • Bir nesne üzerinde var olan tüm memberların tamamı derleme zamanında belirgindir.
     • Yani, derleme aşamasında hangi nesne üzerinden hangi metotların çağrılabileceği bilinmektedir.
     */

    //Sanal yapılar, bir sınıf içerisinde bildirilmiş olan ve o sınıftan türeyen alt sınıflarda da tekrar bildirilebilen yapılardır.
    //Sanal yapılar methot yada property olabılırler

    //bir sınıfta tasarlanmış sanal yapının işlevinin iptal edilip edilmeme durumuna göre tanımlandığı sınıftan mı yoksa bu sınıfın torunlarındanmı cagırılacagının belirlenmesi run time da gerceklesecektır
    /*
     Bir sınıfta tanımlanmış olan herhangi bir member'ın
kendisinden türeyen alt sınıflarda Name Hiding durumuna
düşmemeksizin ezilip/yeniden yazılıp yapılandırılması için
kullanılır.
     */

    class A
    {
        public virtual void x()
        { //sanal bir methot
            Console.WriteLine("x methodu a daki");
        }
    }

    /*
     Bir class'ta virtual ile işaretlenerek sanal hale getirilmiş bir
    member(metot ya da property), bu class'tan miras alan
    torunlarında ezilmek/yeniden yazılmak isteniyorsa eğer ilgili
    class•ta imzası override keywordü işaretlenmiş bir vaziyette
    tekrardan aynı member oluşturulur.
     */

    //•override• keywordünü ileride Abstract Class'lann implemantasyonunda da kullanacağız.
    class B : A
    {


        public override void x() //sanal yapııy ezdik
        {
            Console.WriteLine("Overide edılmıs hali b de ki");
        }
    }

    class Obje
    {
        public virtual void Bilgi()
        {
            Console.WriteLine("Ben bir objeyim");
        }
    }

    class Terlik : Obje  //terlık.Bilgi(); deyınce --->Ben bir terliğim calısır overıde ettıgımız ıcın 
    {
        public override void Bilgi()
        {
            Console.WriteLine("Ben bir terliğim");
        }
    }

    class Kalem : Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Ben bir Kalemim");
        }
    }

    /*
     Bir Class tâ virtual işaretlenmiş herhangi bir member illa ki direkt türeyen I. dereceden class'lar da override edilmek mecburiyetinde değildir!
       İhtiyaca binaen alt seviyede ki torunlardan herhangi birinde override edilebilir.
     */
    /*
     Lakin köyle bir durumda kritik bir durum vardır! O da ilgili soyut
member'ın en son override edildiği Object'ten sonra geçerli
olduğudur.
Ve 0 object'ten sonra hiyerarşik olarak türetilen sınıflar varsa
onlarda da override işlemi gerçekleştirilebilir.
     */

    class Memeli
    {
        public virtual void Konus()
        {
            Console.WriteLine("Ben konuşmuyorum ");
        }
    }

    class Maymun : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben bir Maymunum");
        }

    }

    class Orangutan : Maymun
    {
        //burada overide edilmez ise Ben bir maymunum der
        //bi oncekı dekı overıde var ıse onun degerı gelır
    }
    class İnek : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben bir İneğim");
        }
    }



    #endregion

    #region Örnek

    class Sekil
    {
        protected int boy; //protected sadece bu sınıf yada bu sınıftan kalıtım almıs yerlerden ulasılabılır
        protected int en;
        public Sekil(int boy, int en)
        {
            this.boy = boy;
            this.en = en;
        }

        public virtual int Alanhesapla()
        {
            return 0;
        }
    }

    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {

        }
        public override int Alanhesapla()
        {
            return base.boy * base.en / 2; //kalıtım aldıgı yerden getırıyoruz bu boy ve en i
        }
    }

    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {

        }

        public override int Alanhesapla()
        {
            return boy * en;
        }
    }

    class Ditdortgen : Sekil
    {
        public Ditdortgen(int boy, int en) : base(boy, en)
        {

        }

        public override int Alanhesapla()
        {
            return boy * en ;
        }
    }

    #endregion
}
