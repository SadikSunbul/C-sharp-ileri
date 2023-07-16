using System;

namespace _2._2.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass3 my = new() {
             A = 1,
              MyProperty1 = 2
            };
        }
    }

    #region sealed Keyword'ü Nedir? Ne Amaca Hizmet Etmektedir?
    //Bir sınıfın miras vermesini yahut bir başka deyişle başka bir sınıf tarafından miras alınmasını engelleyen bir keyword'dür.
    //Sadece sınıflarda ve sadece 'override' edilmiş metotlarda kullanılabilir.
    //recordlarda sınıf fıtratında oldugu ıcın ondada kullanılır

    /*
     Metot Üzerinde sealed Keyword'ünün işlevi
Kalıtımsal durumlarda, atalardan gelen ve birinci dereceden alt
sınıf tarafından 'override' edilmiş olan 'virtual' member'ların
hiyerarşidekisonraki sınıflar tarafından 'override' edilmesini ilgili
member'ı sealed ile işaretleyerek engelleyebiliriz.

    Pratikte bu yöntem sayesinde üst sınıfın davranışını güvenli bir
şekilde korumuş ve ilgili metodun değiştirilmesini önlemiş
oluyoruz.
     */



    sealed class A
    {

    }
    class B //:A kalıtım veremeyiz cunkı sealed kullanılmış
    {

    }

    class X
    {
        public virtual void A() { Console.WriteLine("x"); }
        
    }
    class Y : X
    {
        public sealed override void A()//sealed yaparsak bundan sonrakı yerlerde overide edilemez halae gelir
        {
            Console.WriteLine("y");
        }
    }
    class Z : Y
    {

    }

    /*sealed Keyword'ü Hangi Durumlarda Kullanılmalıdır?
     Sınıfların Davranışlarını Korumak stediğimizde
Kalıtımsal Hiyerarşide üst sınıfların özel metotları/davranışları varsa ve bu
metotlardaki davranışların alt sınıflar tarafından değiştirilebilir olmasını istemediğimiz
durumlarda, o rnetodu sealed olarak işaretleyebiliriz.

    Performans İyileştirmesi İstendiğinde
Mikro seviyede yapılan bir optimizasyon neticesinde C#'ta bir sınıf sealed ile
işaretlendiğinde sealed olmayan bir sınıfa göre ufak çapta bir performans artışı
gösterdiği anlaşılmıştır, Bunun nedeni, derleyicinin sealed ile işaretlenmiş sınıfın
miras alınamayacağını bilerek daha hızlı derleme yapmasıdır.

    Singleton Design Pattern
Singleton Design Pattern'da bir sınıfın uygulama çapında tekil bir instance'jmn
olması amaçlanmaktadır. Haliyle ilgili sınıf sealed ile işaretlenerek, bu sınıftan
herhangi bir kalıtımsal ilişkinin yaratılmasını engelleyebilir ve tek üretimini
daha da garanti hale getirmiş oluruz.


     */
    #endregion
    #region Sınıf Modeline Özel Keyword'ler | this | base | readonly
    #region this
    //Bir sınıfın uygulamaın haehangi bir noktasında türetilmiş olan instance larıını objectlerını nesnelerını sınıf ıcerısınde temsıl etmemizi saglıyan keyword
    //ctor lar arasında atlamamızı saglar
    class MyClass
    {
        int a;
        public MyClass()
        {


        }
        public MyClass(int a) : this() //ilk this olan yer calısır 
        {
            this.a = a;
        }
    }
    #endregion
    #region base
    //base clasın ınstenc ını temsıl eden bır keyword dur
    //base clastakı ctorlara secim yapmamızı saglar
    class a1
    {
        public int a_1 { get; set; }
        public a1()
        {
            
        }
        public a1(int a)
        {
            
        }
    }
    class a2:a1
    {
        public int a_2 { get; set; }
        public void y()
        {
            base.a_1 = 1;   
        }
        public a2():base(12)
        {
            
        }
    }
    class a3:a2
    {
        public void x()
        {
            base.a_1 = 1;
            base.a_2 = 2;
        }
        public a3():base()
        {
            
        }
    }

    #endregion
    #region readonly
    //bir clas ıcınde tanımlanmıs olan degıskenın yada referanson sadece okunabılır olmasını saglııyan bır keyword
    //readonly degerleri ya tanımlamada yada ctor da verile bilir baska bı yerde set edemezsin bunun degerini

    class MyClass1
    {
        const int y = 5; //const ilk tanımlandıgı yerde degeri atanır ctorda da deger ataması yapılamaz
        readonly object x;

    }

    #endregion
    #region Init-Only Propertıes
    //C# 9.01da, herhangi bir nesnenin propertylerine ilk değerlerinin verilmesi ve sonraki süreçte bu değerlerin değiştirilmemesini garanti altına almamızı spğlayan Init - Only Properties Özelliği gelmiştir.
    //Bu özellik sayesinde nesnenin sadece ilk yaratılış anında propertylerine değer atanmakta ve böylece iş kuralları gereği runtime'da değeri değişmemesi gereken nesneler için ideal bir önlem alınmaktadır

    class MyClass3
    {
        readonly int a; //buna degerı ya ctor da yada nuradan deger atanabılır yada propertysını ınıt yaparsın initializers ederken atarsın 
        public int A { get => a; init => a = value; }

        public int MyProperty { get; } = 10;//readonly nerde de deger atıyabılrız --> ctor veya burada default oalarak verılebılır 
        public int MyProperty1 { get; init; } = 3; //Init-Only Propertıes için set yerine init yazarız 
    }
    #endregion

    #endregion
}
