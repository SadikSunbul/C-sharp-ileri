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
        public A()
        {
            
        }
        public A(int a)
        {
             
        }
    }

    class B:A
    {
        public B():base()  //A nın parametresız halını tetıkler bunu yazmasakta olur cunku default olarak ztn bu calısır 
        {
            
        }
        public B(int a) : base() //buda aynı sekılde bos olanı tetıkler
        {

        }
        public B(int a,string b) : base(a) //burada int parameterlı olanı tetıkler
        {

        }

        public B(string b):this (12,b) //bi ustekı ctoru tetıkler ilk 
        {

        }
    }

    #endregion
}
