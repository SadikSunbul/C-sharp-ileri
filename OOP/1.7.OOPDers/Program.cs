using System;
using System.Buffers;

namespace _1._7.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Özel sınıf elemanları 
            new MyClass();
            new MyClass(15);

            MyClass5 myClass5 = new MyClass5()
            { Name="Sadık",
             Age=20
            };

            //Deconstruct
            var (x, y) = myClass5;//burada kendısı algılar methodu cagırmaya gerek yoktur ismı tam olarak boyle olmalıdır ama 
            Console.WriteLine(x+" "+y);
        }

    }

    #region Constructor Methot Nedir?
    //Constructor bir nesne üretimi surecınde ilk tetıklenen metotdur new Myclass(Ctor) ctor mecbur tetıklemek zorunludur  
    //Nesneye ait Configration (Yapılandırma) larımızı yaparız 
    /*
     Constructor. özel bir sınıf elemanıdır.
    Özel olsadö fıtrat olarak bir metottun
    Lakin bildiğimiz metot imzalarından bir nebze farka sahiptir.
    Constructor' lar m;

    Metot adı sınıf adıyla aynı olmalıdır! (Özel sınıf elemanla
    dışında hiçbir member sınıf adıyla aynı olamaz!)
    Geri dönüş değeri olmaz/belirtilmez!
    Erişim belirleyicisi public olmalıdır! (private olduğu durum
    ayriyetten incelenecektir)
     */
    //her bır sınıfın ıcerısınde sen koyamasanda default bı sekılde ctor vardır 
    //ctor parametre alır ama statıc ctor veya dector parametre alamaz

    //ctor Overload edilebilir
    public class MyClass
    {

        public MyClass() //ctor yaz tab tab yap
        {
            Console.WriteLine("Bır adet myclas ctor olusturulmustur"); //her nesne ıcın ayrı ayrı tetıklenir

        }
        #region This keywordu ctor lar arası gecıs 
        public MyClass(int a) : this() //ilk once this dekı ctor tetıklenır 
        {
            Console.WriteLine(a);
        }

        public MyClass(string isim, int a) : this(a) //ilk once this dekı ctor tetıklenır 
        {
            Console.WriteLine(isim);
        }

        #endregion

    }

    //Record lar ıcınde aynı seyler gecelı cunkı recorda bır nesnedir
    record r
    {
        public r()
        {

        }
        public r(int a) : this()
        {

        }
    }
    #endregion

    #region Destructor Metot Nedir?
    //Bir class'tan üretilmiş olannesne imha edilirken otomatik çağrılan metottur.

    //C# programlama dilinde Destructor sadece Class yapılanmasındakullanılabılır bır class sade ve sadece tek bır tane Destructor ıcerebılrı parametre alamaz

    //Garbec collecter (cop toplayısı) nı tetıklemek ıcın  GC.Collect(); yeterlıdır pek tavsıye edilmez


    class MyClass1
    {
        public MyClass1()
        {
            
        }
       
        ~MyClass1()//Destructor boyle tanımlanır 
        {

        }
    }

    #endregion

    #region Deconstruct Methodu Nedir?
    //Bir sınıf içerisinde "Deconstruct” ismiyle tanımlanan metot,compiler tarafından özel olarak algılanmakta ve sınıfın nesnesi üzerinden geriye hızlıca Tuple bir değer döndürmemizi sağlamaktadır.



    class MyClass5
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Deconstruct(out string isim, out int yaş) //buradakı parametrelerı tuple olraka gonderi
        {
            isim = Name;
            yaş = Age;
        }

    }
    #endregion
}

