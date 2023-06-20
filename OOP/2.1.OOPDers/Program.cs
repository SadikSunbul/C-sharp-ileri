using System;

namespace _2._1.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polimorfizm 
            MyClass m = new MyClass();
            MyClass m1 = new MyClass2(); //bunu yapabılmemızın sartı MyClass2 --> MyClass den turemesi
            A a1 = new A();
            A a2 = new B();
            C c = new B();

            //Atası ile referans edilebilir


            Erkek e1 = new Erkek();
            e1.erkek();
            e1.insan();
            İnsan e2 = new Erkek(); //erkek hem erkedir hemde insandır
            e2.insan();
            // e2.erkek --> hata verırı gelmez burada erkegın ınsan özelliklerine bakabiliriz
            
            Kadın k1 = new Kadın();
            İnsan k2 = new Kadın();

        }
    }


    #region Polimorfizm 

    //oop de ıse polımorfızım e :İki yada daha fazla türün sınıf tarafından karsılanabılmesı referans edılebılmesıdır dıyebılırız Bir başka deyişle: Bir nesnenin birden fazla farklı turdeki referans tarafından şaretlenebilmesi polimorfizm dir.

    /*
     Polimorfizm, OOP tasanmlarında geliştirilen koda daha manevrasal bir şekilde nitelik kazandıran ve yaklaşım sergilememizi sağlayan bir özelliktir.
    Polimorfizm, programlamada ki temel prensip olan 'Sol/Sağ Prensibi'ni;aşıp, eldeki nesnenin birden fazla referansla işaretlenebilmesini sağlar.

    A a=new A();
    A a=new B(); //burada b a dan turemelidir
     */


    /*
        Yani,
        'Kuş' cinsinden olan tüm hayvanların kendi türlerinin dışında
        bir yandan 'Kuş' olarak tarif edilmeleri çok biçimliliktir....
        Peki kuş olmayan bir hayvana 'Kuş' diyemiyoruz! Misal
        Maymun'. Bir 'Kuş' değildir! Buradan şöyle bir sonuca
        varabilir miyiz?
        Ortak atadan gelen, kalıtımsal olarak 'Kuş'tan türeyen
        tüm hayvanlar kendi türleri yahut 'Kuş' türü ile referans
        edilebilirler...
     */
    /*
     Evet... Bir nesnenin başka bir nesne ile işaretlenebilmesi referans edilebilmesi için kesinlikle arada kalıtımsal bir ilişki olması gerekmektedir

        Yani bir başka deyişle, Nesne Tabanlı Programlama 'da Polimorfizm uygulamak tstiyorsanız türler arasında kalıtım uygulanmıs olmalıdır .

      Ya da bam başka bir deyişle: Nesne Tabanlı Programlamada Polimorfizim aralarında kalıtımsal İlişki olan sınıflarda uygulanabil". Aksi mümkün değildir!

     */

    class MyClass
    {

    }
    class MyClass2 : MyClass
    {

    }

    class A
    {

    }
    class B : C //burada A,C dersek hata olur 
    {

    }

    class C : A
    {

    }


    class İnsan
    {
        public void insan() {}
    }
    class Erkek : İnsan
    {
        public void erkek() { }
    }
    class Kadın : İnsan
    {
        public void kadın() { }
    }

    #endregion
    #region Nesneler Arası İlişki Türleri (Association-Aggregation-Composition)
    //Nesneler arasındakı ılıskı turlerı 

    /*
     is-a ilişkisi -->Tamamı ile kalıtımla alakalıdır opel is a araba --> opel bir arabadır dir 

    has-a ilişkisi -->Bir sınıfın başka bir sınıfın nesnesıne dair sahiplik ifadesi bulunan ilişkidir Bir yandan Kompozisyon/composition ilişkiside denmektedir 
        opel has a motor  --> opelin bir motoru vardır 
    class opel{
    Motor motor;
    }
    class motor
    {
    }

    can-do ilişkisi
     */


    #endregion
}
