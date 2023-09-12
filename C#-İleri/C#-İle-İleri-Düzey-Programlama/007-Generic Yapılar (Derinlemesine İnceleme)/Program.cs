
#region Generic Yapılar (Derinlemesine İnceleme)
/*
 Generic Yapılar Nedir? Ne Amaca Hizmet Eder?

C#'ta generic yapılar, veri tipi bağımsız
yapılar(class, interface, struct , metot
ve delegate) oluşturmamızı sağlayan,
dilin yeteneği olan özel bir niteliktir.

Genel mantığı farklı veri
tiplerinde çalıştıracağımız durumlaru
tasarlamak için generic yapılardan
istifade edebiliriz.

Böylece her bir tip için aynı işi tekrar
ekrar yapmaktansa tek seferde yapıp,
tüm türler için genelleyebilmekteyiz.

Buna örnek verm miz gerekirse eğer; misal olarak meyve
sepeti uygulaması geliştirdiğinizi varsayalım. Sepette farklı
tipte meyveleri Saklamak istiyoiSunuzjİŞte bu durumda her
bir meyve için ayrı ayrı çalışma yapmaktansa aşağıdaki gibi
generic yapılar eşliğinde tek bir sepet çalışması yapabilir ve
bunu tüm meyvelere genelleyebilirsiniz
 */
/*
 Peki generic yapılar hangi amaçlara hizmet eder?

-->Veri Tipi Bağımsizliğı
Generic yapılar, farklı Veri tipleri üzerinde çalışacak kodun tekrar kullanılmasını sağlarlar.

-->Performans ve Bellek Tasarrufu
Her veri tijrij için ekstradan bir çalışma yapmak bazen kodun
performansını azaltabilir, bellek tüketiminde ise maliyete sebep
olabilir. Halbuki generic yapılar sayesinde, ortak operasyonlar için
genelleştirilmiş bir yaklaşım sergilenerek daha performanslı ve az
maliyetli çalışmalar gerçekleştirilebilir.

-->Tip Güvenliği
Generic yapılar, derleme zamanında tip güvenliği sağlamaktadırlar!
Evet, veri tipi bağımlılığından kodu törpülemektedirler lakin dersimizin
devamında göreceğimiz constraint'ler sayesinde uyumsuz veri tiplerini
eleyerek, olası hatalardan kodu arındırabilmektedirler. Ya da o an da
generic yapıya hangi tip verildiyse, sadece o tipe özgü çalışmalara izin
vermektedirler.

-->Kodun tekrar kullanıla bilirliği
Generİc yapılar İle aynı temel iş mantığını farklı veri tipleri İçin
uygulamada genelleyebilmekte ve böylece kodun yeniden kullanılabilir
olmasını sağlayabilmekteyiz.

 */

/*
 Hangi Yapılar Generic Olabilir?
class lar methot struct interace record delegate ...
 */

#endregion

#region Generic Class lar
/*
 Generic class'lar, programlama
dilinde farklı veri tipleriyle çalışabilen
class'lardır.
 */
#region Generic class Tanımalama kuralları
/*
 Bir class'ı generic hale getirebilmek
yani generic Class yapabilmek için, sınıf
adının sonuna 'T' gibi bir parametre
eklenmelidir!

BU T parametresi, ilgili sınıfın generic
davranış göstereceği farklı türleri
temsil edecek olan bir semboldür
diyebiliriz.

Ayrıca bu işimsel olarak farklı bir ada da
sahip olabilir. Misal olarak; A, B, XY ya da
Ahmet, Mehmet gibi isimler de verilebilir.
Amma velakin bu parametreler tipleri/türleri
temsil edecekle?inden dolayı type'ın baş harfi
olan T ya da benzeri sembolleri tercih etmek
daha mantıklı olacaktır!

bu T parametresi
sayesinde, MyClass içerisinde
farklı türleri temsil edebilecek ve
genelleştirilmiş davranışlar
sergileyebileceğiz.
 */
#endregion

/*
 yani görüldüğü üzere MyClass türünü
bizler T parametresi sayesinde farklı
Meri tipleri için de davranış
sergileyebilecek şekilde
genelleştirebilmekteyiz.
 */

using System.Runtime.CompilerServices;

MyClass<int> deneme = new(); //Tüm generik parametreler verilmelidir

class MyClass<T>
{
    T deneme { get; set; }  //Burada T = int olursa deneme int türünden bir değer tutar
}
class MyClass1<T1, T2, T3> //gibi farklı tiplerde alına bilir
{

}

#region Generic Sınıfların Kalıtımdaki Rolü
/*
 Bir generic sınıf, generic olan ya da
olmayan herhangi bir başka sınıf dan 
kalıtım alabilir. Aynı şekilde generik
olmayan bir sınıfta, generic olan
sınıftan kalıtım alabilir.
 */

//1. Generic Olmayan Sınıfın, Generic Sınıftan Kalıtım Alması

class MyClass2 : MyClass3<int>
{

}
class MyClass3<T>
{

}

//Generic Sınıfın, Generic Olmayan Sınıftan Kalıtım Alması
class MyClass4
{

}
class MyClass5<T> : MyClass4
{

}

//3. Generic Sınıfın, Generic Sınıftan Kalıtım Alması

class MyClass6<T> : MyClass7<int>
{

}
class MyClass8<T> : MyClass7<T>
{

}
class MyClass9<T, T2> : MyClass7<T2>
{

}
class MyClass7<T>
{

}
#endregion

#endregion

#region Generic Metotlar
/*
 enericc S'ları biliyorsanız, generic
interface, struct ve record'lar da birebir
aynı mantıkla tanımlanıp,
kullanılmaktadırlar. Lakin generic
metotlar öyle değil...'

Bizler yapısal olarak bir methodu 'da •
generic olarak tanımlayabiliyor ve
kullanabiliyoruz,

Generic metotların tanımlanması için
herhangi bir öncül şarta gerek yoktur.
Yani bu metotların tanımlanacağı
sınıflar ister generic isterse de non
generic olması fark etmiyor

Ya da interface içerisihde tariımıanan-
metot imzası da generic olabilir veya
abstract class'daki abstract elemanda.


 */
#region Generic Methot Tanımlama 
/*
 Bir metodun generic olması için
isminin yanına tür parametresinin
tanımlanması gerekmektedir.

işte bu tür parametresi artık bu
metodun parametrelerinde, geri
dönüş değerinde ya da operasyonel
olarak içerisinde kullanılabilir.


 */

class MyClass10/*<T>*/ //iki durumda olur 
{
    public void Dneeme<T1>(T1 değer)
    {
        T1 asd;
    }
}
#region Generik metot kullanımı 
/*
 Generıg metotların kullanımı da
oldukça basittir. Metodu çağırırken
generic parametrelere türlerinin
verilmesi yeterli olacaktır
 */

class MyClass11
{
    public void A()
    {
        MyClass10 my = new();
        my.Dneeme<int>(12);
        my.Dneeme(13); //Böylede kullanılyor bu kulalnım kritik kullanımdır 
        my.Dneeme("asfhşuıau");
        /*
 Generic metotları kullanırken bu şekilde tür paramettelerinin değerlerini bildirebileceğiniz gibi metodun parametrç!eri
üzerinden de direkt değer vererek o değerin türüne göre opsiyonel bir bildirimde:bulunabilirsiniz..
        Bu yontemı cok kullanıcaz bunu bılmek sart
 */
    }
}



#endregion
#endregion

#endregion

#region Generic Yapılarda Kısıtlamalar(Constraints)
/*
 Genericy ılarda tanımla ıgımız tür
parametrelerine kodu daha da
güvenilir, anlaşılır ve küllanışlı hale
getirmek için belirli kısıtlamalar
getirilebilmektedir.

BU kısıtlamalar sayesihde tür
parametrelerinde kullanılacak türleri
belirleyebilir ya da belirli bin
sınırlamaya tabi tutabilir.

Filanca parametresinin sade ve
sadece Class türlerini almasını
isteyebilir ya da class'lardan sadece A
ve A'nın türevi olan türlerden olmasını
isteyebiliriz...

Veyahut yine filanca T parametresinin
kesinlikle nesne pluşturulabilir bir tür
olmasının garantisini de sağlamak
isteyebiliriz...

İşte bu ve bunlara benzer ihtiyaçlara
istinaden generİc parametrelerine
kısıtlamalar uygulaya;ak kodu daha da
-güvenli hale getirebilmekteyiz.

Kısıtlamaların amaçlarını genel olarak
-ele almamız gerekirse eğer şöyle izah
edebiliriz;

-->Tür Güvenliği
Constraint'ler, tür parametrelerinde belirli türlerle
çalışmamızı sağlayarak, beklenmeyen tür hatalarının önüne
geçip, tür güvenliği sağlayabilirler. Misal olarak; bir generic
metot yahut sınıfın; belirli bir arayüzü uygulayan türlerle
sınırlandırılmasını sağlayarak, yalnızca Uygun türlerle
kullanılmasını sağlayabilirsiniz.

-->Daha Anlamlı Hata Mesajları
Constraint'ler sayesinde, kullanıcılara uygun olmayan tür
kullandıklarında, durumu açıklayıcı anlamlı mesajlar
verebilmek imkanı elde edebilmekteyiz.

-->Kod Tekrarını Azaltma
Generic yapılanmalarda, kısıtlamalar sayesinde uygun
olmayan türler için kod tekrarı engellenerek,
azaltılabilmektedir.

-->Optimizasyon ve Performans İyileştirmeleri
Constraint'ler, belirli türlerin kullanılmasını zorlayarak,
daha spesifik ve optimize edilmiş kodlar oluşturmamıza
yardımcı.olabilirler.

Özetle; generic constraint'ler, kodun daha güvenli,
anlaşılır ve esnek hale gelmesini sağlamak için
ompileffa, tür parametrelerinin sahip olması gereken
yetenekleri hakkında bilgi veren önemli araçlardır.
 */

#region Kısıtlamalar(Constraints) Nasıl Tanımlanır?
/*
 Generic parametrelere kısıtlamaları vermek için
aşağıdaki gibi where keyword'ünden istifade
edilmektedir.
 */

class MsyClass<T> where T : class  //T class turunde bırsey olsun 
{

}
//Struct int double char vb string hariç
class MsdyClass<T, T1> where T : class where T1 : struct
{
    public void x<T>() where T : class
    {

    }
}
#endregion
#region Kısıtlama(Constraint) Türleri Nelerdir?
/*
 Normal şartlarda herhangi bir generıc tur
parametresi için varsayılan temel sınıf Object'tir.
Yani Object tarafından karşlanabilen tüm
türler(class, struct, iecord, interface, abstract
Class, delegate), tüt parameçrelerine verilebilir.

Eğer ki gerieric parametrelere bir kısıtlama
uygulamak istiyorsanız aşağıdaki constraint
„türlerinden istifade edebilirsiniz;
 */
/*
 Value Type Constraint
Tür parametresinin bir değer
türü olması gerektiğini belirten
kısıtlamadır.
Kullanımı
Where T : struct
 */

/*
 Reference Type Constraint
Tür parametresinin bir referans
• türü olması gerektiğini belirten
kısıtlamadır.
Kullanımj
where T : Class

class degılde referans turlu hersey olabılır record ınterface vb seyler
 */

/*
 New Constraint & Parameterless Constructor Constraint
Tür parametresinin nesne oluşturulabilir bir tür olması gerektiğini belirten kısıtlamadır.
Bunun için verilecek türün constructor'ı parametresiz ve public olmalıdır. Ayrıca static
veya abstract Class olmamalıdır! Bunun şanlara uydukça;struct ya da record olabilir.
Kullanımı
where T : new()

Herhangıvbir class olamaz ctor private ıse olamaz newlene bılen seyler burayı karsılar

constructer public ve parametresiz olamlıdır

statıc sınıflarda olmaz cunku new lenmez
 */

class MyClassasf<T> where T : new()
{
    T t = new T(); //bunu new varken yapa bılırız new ı siler isek hata verırr
}

/*
 Base Class Constraint
Tür parametresinin belinilen türde ya da
- -kalıtımsal olarak alt türünde bir tür
olması gerektiğini belirten kısıtlamadir.
Kullanımı
where T : Base Class Adı
 */

class safsd
{
    public void A()
    {
        afsas<a> asf = new();
    }
}

class afsas<T> where T : b //ya b olucak yada b den tureyyen bısey olucak 
{

}

class a : b
{

}

class b
{

}
class c
{

}

/*
 Interface Constratint
Tür parametresinin belirli bir
arayüzü uygulaması gerektiğini
belirtir.
Kullanımı
where T : 'Interface Âdı
 */

/*
 Enum Constraint
Tür parametresinin bir enum
türü olması gerektiğini belirten
kısıtlamadır.
Kullanımı
where T : Enum
 */

/*
 Unmanaged Constraint
Tür parametresinin
yönetilmeyen(unmanaged) bir tür
olması gerektiğini beliıten kısıtlamadır.
Kullanımı
whereT : unmanaged
 */

/*
 Not NUII Constraint
'Tür parametresinin null
yapılamayan bir tür olması
gerektiğini belirten kısıtlamadır
Kullanımı
where T : notnull
 */

/*
***************** Default Constraint  ****************
Tür parametresinin null veya varsayılan bir değere sahip olan türlerden
olması gerektiğini belirten kısıtlamadır. Sadece override metotlarda ve • .
explicit implementation edilmiş interface metotlarında kullanılabilmektedir.
Kullanımı
where T : default
 */

class asfsdgsa<T> /*where T:default*/ //burası hata verır boyle kullanulmaz
{

}

class Aa
{
    public virtual void X<T>()
    {

    }
}
interface IInterface
{
    void Y<T>();
}

class Bb : Aa, IInterface
{
    public override void X<T>() where T : default //overide edilmiş buradada kullanıla bılırler
    {
        base.X<T>();
    }

    //Acık uygulananlarda uygulanabılır ler
    void IInterface.Y<T>() where T : default
    {
        throw new NotImplementedException();
    }

    //public void Y<T>() where T:default //burasıda hata verıcektır
    //{
    //    throw new NotImplementedException();
    //}
}

#endregion
#region Bir Generic Parametreye Birden Fazla Farklı Constraint Tanımlama
/*
 Bazen bir ge eric parametreye, birden fazla
farklı constraint tanımı gerçekleştirmek
gerekebilmektedir. Misal olarak; T
parametresinin llnterface'i implement eden bir
referans türünden olmasını ve biryandan da
nesne üretilebilir bir Class olmasını istiyorsak
yandaki gibi bir çalışma yapılması
. gerekmektedir.
 */
class asfsdgsd<T> where T : class, IInterface, new()
{

}
/*
 Tabi burada yapılan birden fazla constraint uygulama çalışmaları mantıken tutarlı
olmalıdır. Yani hem reference type constraint'i(class) hem de value type
constraint'i(struct) tek bir parametreye uygulamak gibi ya da value type
constraint'in(struct) yanına new constraint'i(new()) uygulamak gibi tutarsız
işlemlerin derleme hatasına sebebiyet vereceği UNUTULMAMALIDIR!
 */
#endregion

#endregion

#region Generic Özellik Sayesinde Overloading
/*
 C#'ta overload kavramını temel
programlamadaki metotlardan
biliyoruz:

Overload metotlarla aynı isimde
birden fazla metot tanımı
gerçekleştirebiliyoruz.

- İlgili derslerde hatırlarsanız eğer
ovevloading yapılanmasını ileride generic
yapılanmalarla da gerçekleştireceğimizden
bahsetmiştik...

Eyet, C#'ta overloadinglü
uygulayabildiğimiz bir diğer özellik
generic yapılanmalardır.

Genericy pılanmalarsayâsihde; bir
metotla birlikte bu sefer de Class,
ihterface vs. seviyelerinde dâ
overloadifig davranışını
uy ulayabiliyoruz.
 */


class Deneme
{

}

class Deneme<T> //overload uygulandı 
{

}

class Deneme<T, T1> //overload uygulandı 
{

}

class MyClasasfs
{
    public void X() { }
    public void X<T>() { } //overload uygulandı 
    public void X(int x) { } //overload uygulandı 
}
/*
 Burada tek dikkat edilmesi gereken husus, ister
metotlarda isterse de classlar da parametre
sayılarının farklı' olmasıdır. Yani aynı sayıda ama
farklı isimlerdeki generic parametreler
overloading kurallarını sağlayamayacağı için
derleyici hatası verecektir.
 */

//Hata vericektir

//class asfsfafas<T>
//{

//}

//class asfsfafas<T1>
//{

//}

#endregion

#region Generic Yapı İçerisind Generic Yapı Tanımlama
/*
 Bazen kodlama sürecinde generic bir
yapı(class, interface; struct, record)
içerisinde generic başka bir yapı
tanımlayabilir ve şöyle kullanabiliriz...
 */
class asljgkhdh
{
    public void X()
    {
        asfjhlşaj<a>.algsdkyh<a> ig = new(); //gıbı kullanılır 
    }
}
class asfjhlşaj<T1>
{
    public class algsdkyh<T2> where T2 : T1 //T2 T1 veta t1 turevinde bısey olmalıdır 
    {

    }

    class asklgjhjd<T2> where T2 : new()
    {

    }
}
/*
 
 */
#endregion

#region Constructed Type(inşa Edilen Tip) Nedir?
/*
 C# ta generic yapılarım
somutlaştırılmış/hazırfkullanılmış
haline terminolojik olarak
Constructed Type
denmektedir.
 */

/*
 Misal olarak List«iht», List«T» generic
yapılanmasının bir Constructed
Type'ıdır.
 */

/*
 aynı şekilde Dictionary«int, string
Dictionary«TKey, T Value»'nun
constructed type'ıdır
 */

#endregion
