



#region  Struct Veri Türü Nedir? Ne Amaçla ve Nasıl Kullanılır?

/*
 
Struct Nedir? Neden Böyle Bir Veri Türü Vardır?

C#'ta struct, değer türünde bir
veri tipi oluşturmak için
kullanılan bir veri yapısıdır.

Yani anlayacağınız, class'lar ile
referans, struct'lar ile de değer
türlü veriler
oluşturulabilmektedir.

Struct'lar genellikle, class'lara nazaran küçük
boyutlu ve hafif veriler oluşturmak için tercih
edilseler de, kodlama sürecinde performans
ve maliyet optimizasyonları açısından da
tercih edilebilmektedirler.


 */

/*
 -->Performans
Değer türlü veriler, nesnelere nazaran bellekte
daha az yer kapladıkları gibi daha hızlı erişilebilir
yapılardır. BU da performans optimizasyonu
açısından fark yaratacaktır.

-->Maliyet
Nesnelerin oluşturulması ve kullanıldıktan sonra
imha edilmeleri ekstra iş yijkÜ getirebilmektedir.
Struct'lar da ise bu iş yıJkÜ ciddi manada
törpülenmiştir diyebiliriz. BU durumda maliyet
o timizas onı-J açısından fark yaratmaktadır.
 */

/*
 Struct Ne Amaca Hizmet Eder?
Struct' lar temelde, yazılım
sürecinde int gibi, char gibi,
bool gibi kendimize ait değer
türlü değişkenler oluşturmak için
kullandığımız veri türleridir.

Özellikle bellek performansının
kritik arz ettiği uygulamalarda,
Uyguın noktalarda class'lar
yerine struct'ları tercih
edebilirsiniz.

Misal olarak: matematiksel
veriler gibi basit değerleri temsil
etmek için class'lar yerine
struct'lan tercih etmeniz daha
doğru olacaktır.

kordinat sistemindeki
noktalar veya key/value çiftleri
tarzındaki kimi değerleri struct
olarak tanımlamak performans
açısından daha elverişli
olacaktır.

Kıssadan hisse yapmamız
gerekirse eğer; kodlama
sürecindeki birden fazla
değerlerin/verilerin atomik bir
temsili için struct'lan kullanırız!
 */


//Struct Veri TÜrÜ Bellekte Nerede Saklanır?

/*
 Struci'lar, value type yani
değer türlü veri yapıları olduğu
için belleğin Stack kısmında
tutulurlar.
 */

/*
 MyStruct my = new MyStruct()
{
    X = 1,
    Y = 2,
};

struct MyStruct
{
    public int X { get; set; }
    public int Y { get; set; }
}

 * 
 Burada new operatöıü ile kullanılan veri
yapısı struct olduğu için belleğin Stack
kısmında tutulacaktır. Dolayısıyla buradaki
myStruct değişkenine class 'lor da olduğu
gibi referans DEĞİL değişken diyeceğiz! Ve
bu değişken belleğin Stock kısmındaki
tutulan X ve Y alanlarına erişmemizi
sağlayan değer türlü bir değişkendir.
 */



#endregion


#region Struct ile Class Arasındaki Farklar Nelerdir?
/*
    ---> Değertürlü vs Referans Türlü
• Struct, value type bir veri türüdür. BU yüzden bellekte Stack alanında saklanır.
•Class ise referance type bir veri türüdür. Haliyle, referansı belleğin Stack kısmında tutuluyor olsa da instance'ı
Heap kısmında tutulmaktadır.

   --->Kalıtım 
• Struct'lar kalıtımı desteklemez farklı bir class'tan yahut struct'tan türemez veya miras alamazlar. Sadece
interface'leri implement edebilirler.
•CIass'Iarın ise kalıtımsal davranışı doğasında vardır.

   ---> Null değer
•Struct'Iar nullable türleri destekler, ancak varsayılan olarak nullable değillerdir.
• Class'lar ise nullable türlerdir ve varsayılan olarak da null olabilirler.
MyStruct m1=null; //bunu yapamazsın hata vericektir
MyClass m2=null; //bunu yapabilirsin

MyStruct? m1=null; //bunu yapabılırız


   --->Hafıza ve Performans 
•Struct'Iar genellikle daha hafif ve performans odaklıdır. Değer türlü) oldukları için bellekte daha az yer kaplarlar
ve hızlı erişim sağlanabilirler. Ancak, büyük struct veriler performans sorunlarına yol açabilir.
• Class'lar ise daha fazla bellek kullanabilir ve daha yavaş olabilirler. Çünkü referanslar oluşturulması ve bellekte
yer tahsisi yapılması gerekmektedir.

 */
/*
 * • iki struct değerini aşağıdaki gibi Equals fonksiyonuyla karşılaştırırsak burada değer bazlı bir karşılaştırma
yapılacaktır ve sonuç olarak 'Eşit' yazısını ekrana yazdıracaktır.
 
Aynı mantıkla class'ları değerIendirirsek eğer referans
karşılaştırması gerçekleştirirler. Tabi burada istendiği ya da
gerektiği taktirde Equals metodu override edilerek özel bir
karşılaştırma tutumu sergilenebilir.



MyStruct m1 = new()
{
    X = 1,
    Y = 2
};

MyStruct m2 = new()
{
    X = 1,
    Y = 2
};

if (m1.Equals(m2)) //Burası true doner aynı record gibi
{
    Console.WriteLine("Eşit");
}

struct MyStruct
{
    public int X { get; set; }
    public int Y { get; set; }

}
*/

//Maliyet      class > record > struct
//performans   struct > record > class


//Kopyalama Davranişi
/*
 • Struct'lar değişkenler birbirlerine atandıkları taktirde deep copy gerçekleştirilecek ve atanan veri
çoğaltılacaktır. Böylece her iki struct arasında bir bağımsızlık durumu söz konusu olucaktır.

• Class'lar da ise sadece referans kopyalanacak ve shallow copy davranışı söz konusu olacaktır. Böylece bir
nesne birden fazla referans tarafından işaretlenerek, manipüle edilebilir olacaktır.
 */

#endregion


#region Struct Nasıl Tanımlanır ve Kullanılır?
/*
 Görüldüğü üzere bir struct; Class
gibi oldukça kolay bir şekilde
tanımlanabilmektedir.

Dikkat ederseniz eğer struct'ın
içerisinde fieid, property ve
method tanımlayabiliyoruz.

Struct'ların tanımlaması bu kadar
basit. Kullanımına gelirsek eğer
burada new ile kullanmak,
new'siz kullanmak gibi birkaç
farklı durum söz konusu olacaktır.
 */
#region New operatörü ile kullanırsam ne olur?
/*
 Bildigıniz gibi new operatörü
class'lar da kullanıldığı zaman
ilgili ciass'tan bir nesne talep
edilmekte ve üretilen bu nesne
belleğin Heap kısmında
muhafaza edilmektedir.

Struct yapısında ise new operatörünü
kullanırsak eğer, evet ilgili yapıdan bir
nesne vari bir değer üretilecektir ama struct'ın bir
değer tipli veri olmasından dolayı o
nesne belleğin Stock kısmında
muhafaza edilecektir.

Ayrıca new operatörü sayesinde
struct içerisindeki field'lara
default değerleri atanmış
olacaktır ve varsa property ile
metotlar kullanılabilir hale
getirilecektir..

 */

using System.Runtime.CompilerServices;
using System.Xml.Linq;

MyStruct m = new();
m.X = 10;
m.MyMethod();

/*
 Uzun lafın kısası bir struct'ı new ile
kullanmanın esas farkı o struct
içerisindeki property ve
metotların işlevselliğini
kazandırabilmektir.
 */

#endregion

#region New siz kullanım
/*
 Struct'lar da class'lar da ki gibi
nesne mecburiyeti olmadığı için
illa newg operatörüyle kullanmak
zorunda değiliz!

Yani new operatörü ile struct
yapıdan bir nesne üretmeden de
o struct'ı kullanabilmekteyiz.

Tabi sadece o struct'taki field'ları
kullanabilmekteyiz. Property ve
metotları kullanabilmek için
struct'ı new'lememiz
gerekmektedir.

Haliyle new operatörü olmaksızın
kullanılan struct üzerinden bir field'ı
kullanacaksanız, önce o field'ın ilk
değerinin verilmesine özen
göstermelisiniz, aksi taktirde derleyici
hatasıyla karşılaşırsınız.

 */

MyStruct m2;
//m2.MyProperty=123;//Hata verir newlenmedi çünkü
//m2.MyMethod();//Hata verir newlenmedi çünkü
m2.y = 20;
#endregion
struct MyStruct
{
    public MyStruct()
    {

    }
    public int y;//newlemeden sadece field lar kullanılabilir
    private int x;
    public int X
    {
        get => x;
        set => x = value;
    }

    public int MyProperty { get; set; }//buarnın işlevesel olması için new ile kullanılmalıdır

    public void MyMethod() //buarnın işlevesel olması için new ile kullanılmalıdır
    {
        if (x > 0)
            Console.WriteLine("X 0 dan büyük");
    }
}
/*
 Struct'lar da Kalıtımsal Durumlar
Struct veri türleri sadece interface'leri implement edebilirler. Bunun dışında ne farklı bir struct'dan ne de class'dan
kalıtım alıp, verebilirler!
 */

/*
 Struct'ların davranışı sealed class'lara benziyor mu?
Struct veri yapısı, fıtratı gereği kendiliğinden sealed class'lar gibi davranış sergilemekte ve farklı bir struct ile kalıtımsal
ilişkiye girmemektedir.
 */



#endregion

#region Structın this jeywodü ile Kendini Değiştirebilmesi

/*
 Struct veri türü, kendilerini this
keywordü ile altaki  gibi
değiştirebilen yapılardır.
 */

/*
 * 
MyStruct1 m3 = new MyStruct1()
m3.y=123;
m3.X = 321;

Console.WriteLine(m3.X);//321
Console.WriteLine(m3.y);//123

m3.NewStruct();

Console.WriteLine(m3.X);//0
Console.WriteLine(m3.y);//0

*/
struct MyStruct1
{
    public int X { get; set; }
    public int Y { get; set; }
    public void NewStruct()
    {
        this = new MyStruct1(); //kendini yeniliyebilior
    }
}

//class larda bu durum geçerli değildir claslarda thisa keywordü readonly dir structlarda this keywordü hem read  hem write olarak kullanılabilir


/*
 Esasında bu tarz bir işlem Class
yapısı için mümkün
olmayacağından dolayı ilginç
bir özelliktir.

Class'ların this keyword'ü read-
only'ken, struct'lann ise değildir!
Haliyle bu şekilde kendi
içlerinde kendilerini
değiştirebilmektedirler.
 */

/*
 Son Kırıntılar
STRUCT' LAR İÇLERİNDE STATIC ALANLAR BARINDIRABİLİR.
BİR SINIFIN TÜM MEMBER'LARI VALUE TYPE İSE BİR STRUCT, YOK EĞER DEĞİLSE BİR CLASS [ASARLAYIN.
STRUCT' LAR ÖZÜNDE HAFİF(LIGHTWEIGHT) BİR CLASS YAPISIDIR DİYEBİLİRİZ
BELİRLİ SENARYOLARDA, PERFORMANS AÇISINDAN STRUCT'LAR CLASS 'LARA ALTERNATİF OLARAK DEĞERLENDİRİLEBİLİR.
GARBAGE COLLECTİON'IN PERFORMASINI ARTIRABİLMEK içiN STRUCT TERCİH EDİLEBİLİR.
STRUCT'LAR DA STATIC CONSTRUCTOR TANIMLANABİLİR!
BİR VERİNİN STRUCT OLARAK TASARLANABİLMESİ içiN 16 BAYTTAN AZ OLMASINA ÖZEN GÖSTERİLMESİ TAVSİYE EDİLİR(YA Bi S.)
 */


interface IInterface
{
    void X(int deger);
}

struct MyStruct6 : IInterface
{
    public void X(int deger)
    {
        throw new NotImplementedException();
    }
}

#endregion
