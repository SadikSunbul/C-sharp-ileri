using System;

namespace _2._5.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #region Abstract Class Nedir? Ne Amaçla Kullanılmaktadır?
    /*
     Abstract class özunde kalıtımsal davranıs gostererek bır sınıd uzerınde implementasyonlar yapmamızı saglıyan özel bır yapılandırmadır
    
    Abstract class bizlere yarı soyut bır sınıf vermektedir
    Yarı soyut sınıftan kastedilen ise içerisinde normal memberlar barındırabılecegı gıbı kendısını uygulayan sınıflara zorakı uygulattırabileceği memberların ımzalarını barındıran bır yapılandırmadır 
     */

    /*
     Abstract class Nedir? Neden kullanıyoruz?
        Yazılım süreçlerinde abstract class ları kullanma nedeni herhangi bir ihtiyaca istinaden değildir Abstract classlar tercihen kullanılan yapılardır

    Evet genellikle abstract classlara drekt gereklılık oldugu bır durum hıcbir zaman söz konusu olmıyacaktır.Ancakbelirlidurumlarda iradeli bir sekilde abstract classlar ıle davranıs sergılemeyı tercıh edılebılır ve varsa sorunlarımız daha basitleştirici unsur olarak abstract classları kullanabiliriz

     */

    /*
     Absract class ın yapısal ozellıklerı;
    özunde class tır yanı referans turlu bır yapılanmadır dolauısı ıle abstract class turunden bellegı stack bolgesınde bır referans noktası edinilebilir ve bu referansla heap et kı uygun nesneler işaretlenebilir
        
    Abstract classlardan ıradelı sekılde nesne uretılemez
    m m1=new m(); dıyemeyiz
    bu abstrct class turunden bır nesne hıcbır zaman olamaz anlamına gelmemektedir -->Kalıtımsal olarak bır abstract class herhangı bır sınıfa  mıras verdıgı takdırde buradakı davranıs soyle olacaktır
    --> a a1=new a(); deyınce m den kalıtıldıgı ıcın m nesne uratıcektır dolaylı yoldan 


    abstract class m
    {
    //ctor tanımalanabılrı ıceırsınde
    }

    clas a:m
    {
    
    }
     */

    /*
     Tanımlama ve inşaa etme kuralları
    ->Bir abstract class tanımlayabılmek ıcın abstract class keywordu kullanılır
    ->bir abstract class ıcerısınde member lar bılınen kurallarıyla eklenebilir
            ->Normal metot ve propertyler ekelebılır
            ->zorakı olanlarda ekelebılır zorakı ıcın baslarına abstract demek yeterli
            ->zorakı ler prıvate olamaz publıc olmalı
            ->Zorakıler overde edılmesı sarttır
    -->Normal memberlar mıras yolu ıle gelir
    ->1 sınıf sadece 1 abstrac classtan kalıtım alabilir
     */

    abstract class MyClass
    {
        //somut kısım
        public int MyProperty { get; set; }
        public void x()
        {

        }
        int a;

        //soyut kısım
        abstract public void y();
        abstract public void z(int a, string b);
        abstract public int yas { get; set; }


    }

    class MyClass1 : MyClass//MyClass1 cuncret class
    {
        //buradakı ımplament edılen lerın erısım belırleyıcılerı zzorakı publıc olmalıdır degılse hata alırız
        public override int yas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void y()
        {
            throw new NotImplementedException();
        }

        public override void z(int a, string b)
        {
            throw new NotImplementedException();
        }
    }

    #endregion
    #region Miras

    //abstract classlar kendı aralarında mıras verebılrırler

    abstract class x
    {
        public void a() { }
        public void b() { }
        public void c() { }
        public abstract void d();
        public abstract void z();
    }
    abstract class y:x
    {
        public void E() { }
        abstract public void f();

    }
    class z1 : y
    {
        public override void d()
        {
            throw new NotImplementedException();
        }

        public override void f()
        {
            throw new NotImplementedException();
        }

        public override void z()
        {
            throw new NotImplementedException();
        }
    }
    /*
     Abstract Class Referans
    İşaretleme
    esneyi
    Abstract Class yapısal olarak bir referans türlü değişken olduğu için çmmorfizm
    kurallan gereği kendisini uygulayan tüm sınıflan ve bu sınıflardan kalıtım alan alt
    sınıflan referans edebilmektedir.

    Bir sınıf üzerinde abstraction davranışım gerçekleştirirken ihtiyaçlar ve senaryosuna gör
abstract class'lardan istifade ederek elverişli bir şekilde uygulayabilirsiniz.
     */



    #endregion
}
