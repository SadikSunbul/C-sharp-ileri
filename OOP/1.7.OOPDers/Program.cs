using System;
using System.Buffers;
using System.Xml.Serialization;

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
            {
                Name = "Sadık",
                Age = 20
            };

            //Deconstruct
            var (x, y) = myClass5;//burada kendısı algılar methodu cagırmaya gerek yoktur ismı tam olarak boyle olmalıdır ama 
            Console.WriteLine(x + " " + y);
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

    #region Static Constructor
    //bır sınıfta ctor ve statıc ctor var ıse nesne (ilk nesne )uretılırken  ılk statıc ctor tetıklenır ikinci nesne uretılırken statıc ctor tetiklenmez

    //ctor ılgılı sınıftan her nesne uretılırken tetıklenır
    //statıc ctor ıse ılgılı sınıftan ilk nesne uretılırken tetıklenen fonktur 

    //statıc ctor  uygulama bazlı datalarımızı yerlestırdıgımız alandır 


    class MyClass6
    {
        public MyClass6()
        {

        }
        static MyClass6() //erısım belırleyıcısı yoktur overload yapılmaz 1 sınıfta sadece 1 tane tanımlanabılır parametre alamaz
        {
            //bu sınıftan ılk nesne uretılırken ılk tetıklenecek olan metot  
            //uretılen ılk nesnenın dısında bırdaha tetıklenmez

            //statıc ctor un tetıklenebılmesı ıcın ılla ilk nesne uretımı yapılmasına gerek yoktur ilgili sınıf ıcerısınde herhangıbır statıc yapılanmanında tetıklenmseı statıc ctor tetıklenmesını saglıycaktır.
            //            MyClass6.Deneme();   --> bunu yazdıgımızdada tetiklenir statıc ctor burada normal ctor tetıklenmez cunkı nesne uretılmedi

        }

        public static void Deneme()
        {

        }
    }

    #region Singleton Desing Pattern
    //bır sınıftan uygulama bazında sade ve sadece tek bır nesne olusturulmasını istiyorsan kullanılabılecegın bır desıgn pattern 

    class Database
    {
        Database() //Nesne uretımını engelledık burada ctor private yapıldı
        {

        }
        static Database database;
        public Database GetInstance
        {
            get
            {
                return database;
            }
        }

        static Database()
        {
            database=new Database();

        }
    }
    #endregion

    #endregion
}

