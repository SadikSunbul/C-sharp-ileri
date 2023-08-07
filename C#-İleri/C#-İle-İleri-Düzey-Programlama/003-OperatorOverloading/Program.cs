

#region Operator Overloading Nedir?
/*
 C# programlama dilinde operator overloadingı
belirli(mevcut olan) operatörlerin davranışlarını
kendi türlerinize özel bir şekilde biçimlendirmek
için kullanılan bir özelliktir.

Operatördenen şey, genellikleiki değer
arasında bir bağıntı oluşturmamızı sağlayan
davranışsal sembollerdir.

BU semboller, programlama dilinin doğasında
bulunmakta(yani önceden tanımlanmış) ve işlem
yapacakları değerlerin türüne göre de davranışları
önceden belirlenmiştir.

Misal olarak iki sayısal değer arasına + sembolünü
koyarsak eğer bunun programlama dili açısından
aritmetik bir davranış olduğu anlaşılacak ve ona
göre değerler toplama işlemine tabi tutulacaktır.

İşte bizler de + operatörünün sayısal türlerde yaptığı davranış gibi,
kendi oluşturduğumuz özel türlerde de davranışlarını belirlemek ve
programlama sürecinde bundan istifade etmek isteyebiliriz. Bunun için
operator overloading işlemi ile + operatörüne özel türlerimize göre bir
davranış kurgulamamız ve uygulamamız gerekmektedir.

Yani anlayacağınız, + operatörüne özel türlerimize
göre ekstradan bir görev/sorumluluk yüklemesi yani
çoklu yükleme(overload) yapmamız
gerekmektedir

Bunun için iki sınıftan rinde aşağıdaki
gibi bir çalışma yapılması yeterlidir!
Misal olarak Student sınıfını seçersek
 */
/*
Student student = new() { Name = "SADIK" };
Book book = new Book() { Name="Kitap 1",Author="Yazar 1"};

var result = student + book; 
// var result = book+student; //hata verir

class Student
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
    //Altakını yapınca + operatorunu overload etmıs oluruz
    public static Student operator +(Student a, Book b) //solda student sagda book olmalıdır
    { //gerıye student dön demisiz burada dönuste ıstedıgımızı dondure bılırızz tek ıstısnamız void void donmez
        a.Books.Add(b); //burada ilişkilendirme yaptık
        return a;
    }
    //burada publıc ve statık olma sartı vardır 
}

class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
}

class MyClass
{
    //Hata verıcektır cunku bu sınıf ıle alakalı değildir o yuzden derleyıcı hata verıcektir
    //public static Student operator +(Student a, Book b) 
    //{ 
    //    a.Books.Add(b);
    //    return a;
    //}

    
}
/*
bir sınıfta mükerrer olmadığı sürece istediğiniz kadar operator
overloading gerçekleştirebilirsiniz.
 */

#endregion

#region Hangi Operatörlerde Overloading Uygulanır?
/*
 ing'e tabi tutulabilecek
q»ratörler aşağıdadır;

    +,-,/,%
    ++,--
    true,false
    ==,!=,<,>,<=,>=
    explicit veya implicit
    &,|,^,<<,>>,>>>
 */
/*
 Ayrıca overioading edilemeyecek
operatörleri de bilmekte fayda vardır;

    &&,||
    indexer[]
    cast()
    +=,-=,*=,/=,^=,<<=,>==,>>>=
as,await,checked,unchecked,default,delegate,is,nameof,new,sizeof,stackalloc,switvh,typof,with
 */
#endregion

#region Operator Overloading Ne Amaçla Kullanılır?
/*
 Genel olarak Operator Overloading, C# programlama dilinde classlların, struct'ların veya yapılandırılmış diğer türlerin operatörler üzerindeki
davranışlarını özelleştirmek veya yeniden tanımlamak için kullanılmaktadır.
 */

/*
 Daha Doğal ve Sezgisel Kullanım
Operator overloading, kendi oluşturduğumuz
türler için matematiksel veya mantıksal
operatörleri özel davranışlara büründürerek,
nesnelerimiz açısından daha doğal ve sezgisel bir
kullanım sağlar.
Misal olarak, oluşturduğumuz bir matematiksel
içeriğe sahip sınıfta + ve — operatörlerini
overloading'e tabi tutarak, karmaşık sayılar
üzerinde de aritmetik işlemler yapabilir ve bunu
doğal bir davranışmış gibi uygulayabiliriz.
 */

/*
 Okunabilirlik ve Anlaşılabilirlik (Her yerde değil)
Operator overloading, kodu daha okunabilir ve
anlaşılabilir kılmaktadır.
Özellikk matematiksel veya vektörel
hesaplamalar gibi durumlarda, operatörlerin
davranışlarının özelleştirilmesi, matematiksel
denklemleri kodla daha uyumlu hale
getirmektedir.
 */

/*
 Dildeki Metotlarla Tutarlılık
C# programlama dilinde birçok operatör,
esasında dilin işlem yapan metotlarına karşılık
gelmektedirler.
Yani hepsi bir sembolle eşleştirilmiş, özünde
metot olan yapılardır.
BU nedenle, operatörleri overloading'e tabi
tutarak nesnelerinizin diğer metotlarla tutarlı bir
şekilde davranmasını sağlayabilirsiniz.
 */

/*
     Nesnelerdeki Verilerin Kolay Manipülasyonü
Sınıfların instance'larını özel bir şekilde manipüle
etmek için operator overloading kullanılabilir.
Misal olarak; bir dosya işleme sürecinde « ve »
operatörlerini aşırı yükleyerek, verileri dosyadan
okuma ve yazma işlemleri için özel bir şekilde
tasarlayabilirsiniz.
*/
/*
using System.Runtime.Serialization.Formatters;


Server.Dowland(5);
Server.Uploud(5);

Server server1 = new Server();
//ustekıler ıle aynı ıslerı yapıyor bunlar 
if (server1>>5)//dowland
{

}
if (server1<<3) //uploada
{

}

class Server
{
    public static void Dowland(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}.file dowland");
        }
    }
    public static void Uploud(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}.file upload");
        }
    }

    public static bool operator >>(Server server,int fileCount)
    {
        Uploud(fileCount);
        return true;
    }
    public static bool operator <<(Server server, int fileCount)
    {
        Dowland(fileCount);
        return true;
    }

}
*/
/*
 Dil Uzantıları ve Kütüphaneler
Operator overloading, dilin temel özelliklerini
kendi ihtiyaçlarınıza göre genişletmenize ve
kütüphaneler oluşturmanıza olanak tanır.
BU başkalarının sizin oluşturduğunuz özel türlerle
çalışırken daha doğal bir şekilde etkileşimde
bulunmasını sağlar.
 */


#endregion

#region Operator Overloading Hangi Senaryolarda Tercih Edilir.
/*
 Kendi özel veri türlerinizi tanımladığınızda ve bu türler üzerinde operatörler üzerinden davranışlar uygulamak istediğinizde, operator overloading'i kullanabilirsiniz.

C# programlama dilindeki bazı standart türler için operator overloading yaparak, bu türlerin işlemlerini ve operatörlerdeki davranışlarını özelleştirebilir ve genişletebilirsiniz.

Kendi veri türlerinizde, dilde var olmayan operatör davranışlarını eklemek istediğinizde operator overloading'den faydalanabilirsiniz.

Dilin mevcut operatörlerinin davranışlarını genişleterek, ihtiyaçlara daha uygun ve güçlü hale getirebilirsiniz.
 */
#endregion

#region Operator Overloading Sürecinde Nelere Dikkat Edilmelidir ?
/*
 Operator overloading süreçlerinde mantıklı ve anlamlı
bir davranış oluşturulmasına özen gösterilmelidir. Misal
olarak, bir nesneyi belirli bir değerle davranışa tabi
tutacaksanız bunun için * ya da / operatörleri pek
anlamlı olmayabilir.

Operator overloading uygulanan operatörlerin
mümkün mertebe tutarlı davranış sergilemesine Özen
gösterilmelidir. Yani bir çıkarma işlemi için + operatörü
kullanılmamalıdır! BU tarz yanıltıcı hamlelerden
mümkün mertebe Uzak durulmalıdırl

Kod geliştirilebilir ve bakımı kolay bir şekilde
yazılmalıdır. Ve özellikle operator overloading
süreçlerinde hata durumlarına karşı duyarlı ve dayanıklı
inşada bulunulması önemlidir!

Operator overloading'in tercih edildiği davranışlarda
performans da göz önüne alınmalı ve aşırı karmaşık
veya yavaş çalışabilecek işlemlerde mümkün mertebe
tercih edilmemesine özen gösterilmelidir.

Operatör dav nışlarını özelleştirme süreçlerinde,
standart operatörlerin davranışlarını dilin standardına
uygun bir şekilde geliştirmelisiniz. Misali +
operatörüyle çıkarma ya da bölme gibi operasyonlar
ürütmemelisiniz. Uzun lafın kısası, bir operatörü kendi
fıtratının dışında davranışla modellemek, dilin
kavramsal modelini bozacaktır!

Operator overloading süreçleri kullanıcı dostu
dokümantasyonlarla desteklenmeli ve diğer
geliştiriciler için kod sürecinde yapılan işlemler daha
anlaşılabilir hale getirilmelidir.

Operator overloading sürecinde operatörlere simetrik bir
şekilde beyan oluşturmaya özen gösterin. Misal olarak;
belirli bir türe özgü operatörüne bir overloading
uyguluyorsanız, aynı zamanda operatörünü de
overloading uygulamanız gerekir. Zaman bu operatörler
overloading süreçlerinde tanımlama açısından zorunlUlUk
kılacaktırlar. Şimdi gelin bu operatörleri inceleyelim.

 */
#endregion

#region Overloading Sürecinde İkili Beyan Gerektiren Operatörler
/*
 C#'ta bazı operatörler ikili bildirim gerektirirler. BU operatörler;
    == ve !=
    < ve >
    <= ve >=
•   true ve false
operatörleridir.
BU operatörlerden herhangi birinde overloading işlemi uygulanıyorsa
çiftin diğer eşleşen operatörüne de bir beyanda bulunmak zorunludur!
Aksi taktirde compiler hata verecektir.
 */

//MyClass m=new MyClass();

//var m2=m++;
//++m;
//Console.WriteLine(m.Count);//2

/*
 if(m) //burası artık hata vermıycektir
{
}
 */
/*
class MyClass
{
    public int Count { get; set; }
    //< ve > tanımlamak laızm degısle hata verır 
    public static int operator >(MyClass m1,MyClass m2)
    {
        return 1;
    }
    public static int operator <(MyClass m1, MyClass m2)
    {
        return 0;
    }
    // ++ 2 parametre alamaz
    // ++ veya -- operatorlerı overloding işlemlerine tutulurken tekıl bır prametre ıle tanımlanmmak zorundadır
    //Bu tekıl parametre de overlodıng yapıldıgı sınıfın turnden olmak zorundadır 
    //ve geriye ++ , -- operatorleri geriye tanımlandıkları sınıfıtan bır deger dondurmleıdıreler
    public static MyClass operator ++(MyClass m1)
    {
        m1.Count++;
        return m1;
    }

    public static MyClass operator --(MyClass m1)
    {
        m1.Count--;
        return m1;
    }

    //True ve false  operatorlerı overloıdıng uygulanır ıse bu operatorler geıye bool donmelıdır sımetrık bunlar 2 sınıde olusturmak alzım 
    //Parametreleri tekıl olmalıdır ve tanımlandıkları sınıfın referansı olmaıdır 
    public static bool operator true(MyClass m1)
    {
        m1.Count++;
        return true;
    }

    public static bool operator false(MyClass m1)
    {
        m1.Count--;
        return false;
    }
}
*/
#endregion

#region Örnek
DataBase dataBase = new DataBase();

bool connectionState = dataBase + DatabaseTyp.SqlServer;



class DataBase
{
    static string _connectionString;

    public static bool operator +(DataBase d,DatabaseTyp dt)
    {
        _connectionString = dt switch
        {
            DatabaseTyp.SqlServer => "Server ....",
            DatabaseTyp.Oracele => "..."
        };

        //open connectıomn

        return true;
    }
}

enum DatabaseTyp
{
    SqlServer,Oracele
}

#endregion