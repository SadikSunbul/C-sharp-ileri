using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace _1._9.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım Inheritance
            Kadın kadın = new();
            Y a= new();

            a.x = 12; //hangı x ? bılınmıyor derleyıcı hata vermez y dekı x bu 

        }
    }


    #region Inheritance (Kalıtım) 1
    //oop nın en önemli özellğidir
    //Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir 
    //Aynı aile grubundan gelen nesnelerin ya da yatayda eşit seviyede olan tüm olguların benzer özelliklerini tekrar tekrar herbirinde tanımlamaktansa bir üst sınıfta tanımlanmasını ve her bir sınıfın bu özellikleri üst sınıftan kalıtmsal olarak almasını sağlamaktadır.
    //Böylece hem kod maliyeti düşmekt hem de mimarisel tasarım açısından avantaj saglanmaktadır.

    //kalıtım sınıflara ozgudur
    //bır sınıf sade ve sadece bır sınıftan kalıtım alabilir

    //Recorlar kendi aralarında kalıtım alıp verırler ıstısnaı tek sınıf ıse object sınıfıdır 
    class İnsan
    {
        public int Yaş { get; set; } //kalıtıma gider
        private string İsim { get; set; } //kalıtımda gitmez
        public string Soyisim { get; set; }

        
        
    }

    class Kadın : İnsan  //Kadın insandan kalıtım alır 
    {
        public bool Makyaj { get; set; }

    }

    #endregion

    #region Inheritance (Kalıtım) 2  
    //Base class ve Derived class nedir?


    //buarada Base class == Araba olur Derived (child) class == Opel olur 
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }

    }

    class Opel : Araba
    {

    }

    class Astra : Opel  //Opel base class astra Derived class ama Araba base class degıldır bu sınıf ıcın bır sınıfın sadece 1 tane base classı olabılır
    {

    }

    /*
     Bir class'ın sade ve sadece bir Base Class'ı olur dedik.
Bunun nedeni, C# programlama dilinde bir class'ın sade ve sadece tek bir class'tan türetilmesine
izin verilmektedir! Aynı anda birden fazla class•tan türeme işlemi gerçekleştirilemez!
    İleride bu şekilde birden fazla kalıtım
    tanımlamasının
    yapılabildiğini göreceksiniz.
    Lakin orada da göreceksiniz ki Z ve W bir
    sınıf olmayacaktır!
     */

    //Kalıtımda nesne uretım sırası 
    /*
     Bir sınıftan nesne üretimi yapılırken kalıtım aldığı depğer varsa eğer Önce o sınıflardan SIRAYLA nesne üretilir. atadan baslar gelır 
     */


    //BİR SINIFIN BASE CLASS CONSTRUCTERINA ULASIM

    class A
    {
        public int a { get; set; }
        public A()
        {

        }
        public A(int a)
        {

        }

        public void x()
        {

        }
    }
    //:base() base classın ctorlarına erısım saglar 
    class B : A
    {
        public int a { get; set; }
        public void asf()
        {
            base.a = 14; //base class 
            base.x(); //privateler gelmez buraya
            this.a = 20; //bu sınıf
        }
        public B() : base()  //A nın parametresız halını tetıkler bunu yazmasakta olur cunku default olarak ztn bu calısır 
        {

        }
        public B(int a) : base() //buda aynı sekılde bos olanı tetıkler
        {

        }
        public B(int a, string b) : base(a) //burada int parameterlı olanı tetıkler
        {

        }

        public B(string b) : this(12, b) //bi ustekı ctoru tetıkler ilk 
        {

        }
    }

    /*
     base Keyword vs this Keyword
• this, bir sınıftaki constructor•ıar arasında geçiş yapmamızı sağlar.
• base, bir sınıfın base class'ının constructor'lanndan hangisinin tetikleneceğini ve varsa
parametrelerinin değerlerinin derived class'tan verilmesini sağlar.
     */
    //Aynca nasıl ki this, ilgili sınıfta o anki nesnenin memberlanna erişebilmemizi sağlıyor, aynı şekilde base'de base class'da ki memberlara erişebilmemizi sağlamaktadır.

    #endregion

    #region Inheritance (Kalıtım) 3
    //Nesnelerdekı Tostring Equals vb.. methotlar nereden gelir? object den gelır tum nesneler onjecten kalıtılır

    //en temel sınıf objectir 

    //İsim saklama (Name hitting) Sorunsalı 
    /*
     Kalıtım durumlannda atalardaki herhangi bir member ile aynı isimde member'a sahip olan nesneler olabilmektedir.
     */

    class X
    {
        public int x { get; set; }
        public int t { get; set; }
    }
    class Y : X
    {
        public new int x { get; set; } //eski
        public int t { get; set; } //suanda bıldırmeye gerek yok
    }
    /*
     Yukarıdakı vır Name Hiding durumu söz konusudur gunumuzde bu sekılde Name hidding durumlarında ekstradan bir bildiride bulunmak zorunlu değiliz
    eskiden new kullanılmalıydaı ama  
     */

    #endregion

    /*
     Recordllar da Kalıtım?
• Record'lar sade ve sadece Record'lar dan kalıtım alabilmektedirler.
• Class'lar dan kalıtım alamazlar yahut veremezler!
• Kalıtımın tüm temel kuralları record'lar için geçerlidir;
    • Bir record aynı anda birden fazla record'dan kalıtım alamaz!
Record'lar da temelde Class oldukları için üretilir üretilmez otomatik olarak
•
Object•ten türerler.
base ve this keywordleri aynı amaçla kullanılabilmektedir.
•
Name Hiding söz konusu olabilmektedir.
• Ve aklıma gelmeyen diğer tüm durumlar da reccrd'lar için geçerlidir.
     */
}
