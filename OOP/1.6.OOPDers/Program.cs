using System;
using System.Net.NetworkInformation;

namespace _1._6.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Init-Only Propertıes
            MyClass mu = new MyClass()
            {
                //buarada MyProperty gelmez cunku readonly burada verebılmek ıcın Init-Only Propertıes ozellıgını kullanılır sadece burada deger verme eklenır nesne olusurken verırısın sonra degıstıremezsın 
                MyProperty1 = 1,//bu degerın gelemsının sebebı Init-Only Propertıes olmasıdır
                A = 12 //readonly int a;  ya deger atamamızı saglar 
            };

            //  mu.MyProperty1 = 2; //buradsı hata verıcektır cunkı bu Init-Only Propertıes olusurken deger atıyabılırsın sonradan degıstıremezsın
            #endregion

            #region Record

            Myrecord r1 = new Myrecord() { A = 1 };
            Myrecord r2 = new Myrecord() { A = 1 };

            Myclass c1 = new Myclass() { A = 1 };
            Myclass c2 = new Myclass() { A = 1 };

            Console.WriteLine("Clas (c1=c2)=?" + c1.Equals(c2)); //burası fase doner cunku farklı nesneler 
            Console.WriteLine("Record (c1=c2)=?" + r1.Equals(r2)); //true doner  cunku degerler aynı oldugu ıcın aynı degermıs gıbı goruruz

            //Recordlar deger turlu nesneler degıldır referans turlu yapılardır 
            #endregion


            Myclass myclass = new Myclass() { A = 5, B = 10 };
            // myclass.B = 15; //yapamazsın cunku deger korunuyor  yenı bır clas olusturup o degerı degıstırmelıyız
            Myclass myclass1 = new Myclass() { A = myclass.A, B = 15 }; //boyle yazıyorsan bıyerlerde sıkıntı vardır tek bır nesne ıcın yaparsın bunu daha fazlası ıcın cok yanlıstır bu 
            Myclass myclass2 = myclass.With(15); //deyınce yenı nesne uretılır ve b degerı 15 olarak gelrı ama buda zahmetlı bunu record olarak tasarla 


            Myrecord m = new Myrecord() { A = 5, B = 10 };

            Myrecord m2 = m with { B=15 }; //boyle kullanmak daha iyidir
        }
    }

    #region Records  c#9.0 ile geldi
    #region Init-Only Propertıes
    //C# 9.01da, herhangi bir nesnenin propertylerine ilk değerlerinin verilmesi ve sonraki süreçte bu değerlerin değiştirilmemesini garanti altına almamızı spğlayan Init - Only Properties Özelliği gelmiştir.
    //Bu özellik sayesinde nesnenin sadece ilk yaratılış anında propertylerine değer atanmakta ve böylece iş kuralları gereği runtime'da değeri değişmemesi gereken nesneler için ideal bir önlem alınmaktadır

    class MyClass
    {
        readonly int a; //buna degerı ya ctor da yada nuradan deger atanabılır yada propertysını ınıt yaparsın initializers ederken atarsın 
        public int A { get => a; init => a = value; }

        public int MyProperty { get; } = 10;//readonly nerde de deger atıyabılrız --> ctor veya burada default oalarak verılebılır 
        public int MyProperty1 { get; init; } = 3; //Init-Only Propertıes için set yerine init yazarız 
    }
    #endregion

    #region Records Nedir?
    //C#Y.O ile gelen Init-OnIy Properties özelliği, nesne üretim esnasının dışında değişmez değerleroluşturulması İçin constructor ve auto property İnitializers yapısının yanında Object İnitializer yapısının kullanılabilir olmasını sağlıyordu.

    //Eğerki bir objeyi bütünsel olarak değişmez yapmak ıstıyorısek o zaman daha fazlasına ıhtıyacımız olacaktır işte bu ihtiyaca istinaden record türü geliştirilmiştir

    //Rcord bır objenın topyenkun olarak sabıt degısmez oalarak kalmasını saglamakta ve bu durumu guvence altına almaktadır .

    //Nesne ön plandaysa bu class Nesneın degerlerı on plandaysa bu record dur
    /*
        Record'lar, class'lara
        istinaden objeden ziyade
        içerisinde bulunan
        dataları sabitleyerek,
        nesneden ziyaden
        verilerini/datalarım Öne
        çıkarmaktadır.

        Record'lar bir class'tır.
        Sadece nesnelerinden
        ziyade, değerleri ön
        plana çıkmış bir Class.
     */
    /* class
     Class'lar davranışsal olarak nesne ön
        plandadır ve bir farklı referansa sahip olan
        nesne farklı değer olarak algılanmaktadır.
        Dolayısıyla Equals(x, y) karşılaştırması
        yanlıştır.
     */

    /*  record
     Rec rd'lar ise verişel olarak değeri ön planda
    aktadır. Sadece nesnel olarak bu veriler
    bir objede tutulmakta lakin
    değiştirilmemektedir.
    Haliyle farklı objelerde de olsa,
    veriler(property değerleri) aynı olduğu sürece
    Equals(x, y) önermesi doğru olacaktır.
     */


    public record Myrecord //bır classtır clas ıcındekı hersey ekelenebılr buraya 
    {
        // public int A { get; set; } //burasıda olur ama degerı on planda tutucagımız ıcın ınıt yapmalıyız degerın degısmesını ıstemedıgımız ıcın 

        public int A { get; init; }
        public int B { get; init; }
    }

    class Myclass
    {
        public int A { get; init; }
        public int B { get; init; }

        public Myclass With(int property2)
        {
            return new Myclass() { A = this.A, B = property2 };
        }
    }

    /*
     record" değiştirilemez objeler oluşturmamızı sağlamaktadır demiştik!
     */
    #region With Expressions
    /*
    Immutable türlerde çalışırken nesne üzeirnde
    değişiklik yapabilmek için İlgili nesneyi ya
    çoğaltmamız/klonlamamız(deep copy) ve
    üzerinde değişiklik yapmamız gerekmekte ya da
    manuel yeni bir nesne üretip mevcut nesnedeki
    değerleri, değişikliği yansıtılacak şekilde
    aktarmamız gerekmektedir.
    Misal, üst tarafta bu tarz durumlara istinaden
    yazılımcıların yılların deneyiminden getirdiği With
    function çözümü ele alınmaktadır.
     */

    #endregion

    #endregion

    #endregion
}
