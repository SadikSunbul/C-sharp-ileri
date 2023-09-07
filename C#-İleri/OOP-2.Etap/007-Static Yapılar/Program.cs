

//Static yapılar, uygulama seviyesinde verileri saklamak için kullanılmaktadırlar.


#region Static Yapılar
/*
 Programlamada Siatic Ne Demek?

Programlamada static terimi farklı
bağlamlarda farklı anlamlara
gelebilen önemli bir terimdir.

BU terimin varlık nedenini anlayabilmek için
öncelikle static yapılanmanın, programlama
sürecinde nasıl bir davranış kazandırdığına
odaklanmamız gerekir.

Bak müdür, şimdi şöyle düşünelim... Normal
şartlarda bir türün verisini kullanmak için ö
türün bir instance'ını üretiriz. Doğru mu?

Static yapılanmada ise veri, Türün
instance'ı ile değil bizzat türün
kendisiyle ilişkilendirilmesini ifade eder.

La olum neşirti anlamadın, maL Eğer kodda stallc bir yapı
varsa, o static yapı üzerinden değer işlemlerini, o static
yapının tanımlandığı türün instance'l üzerinden değil,
bizzat türün üzerinden yürütürsün! Bundan dolayı statlc
yapılardaki verişel işlemlerin türün kendisiyle
ilişkilendirildiğini söyleyebiliriz diyorum.

Static yapıların kullanımı için
nesneye ihtiyaç duyulmaması, kodlama
sürecinde direkt ilgili türün özerinden işlem
yapılmasını sağlamaktadır. Ee bu do sfofic
yapılan, uygulama bazında evrensel veya
tekil olarak kullanılabilen ve erişilebilen
ya pılor olarak karşımıza çıkarıyor-
 */

#region Metafor
/*
 Düşün müdür, Tann
yazılımcısı dünya diye bir
uygulama geliştirmiş...

Bu dünyadaki tüm
insanlar, insan Class
modelinin birer instance'l
yani nesnesidir.

Güneş ve ay ise static
yapı diyebileceğimiz
bileşenlerdir!

Şimdi bu vaziyette, herhangi
bir insanda yapılan bir
müdahale umumiyete
yansımamakta lakin güneş
ve ayda yapılanlar ise tüm
dünyaya yansımaktadır.
Öyle değil mi?

Misal olarak, insanlar
arasından Şuayip abinin
ağzını yüzünü bi güzel
hallaç pamuğuna
çevirsen bu sadece
Şuayip instance'ını
etkileyecek, diğer
insanlarda değişikliğe
sebebiyet vermeyecektir.

Ama güneş veya ay
üzerine örtü örtsen dünya
ebe••• " ••• doğru mu?

İşte güneş ve ay nasıl ki
dünya uygulamasında
uygulama çapında etkin
bir şeyse yazılımda da
static yapılar öyledir.

Yani yazılımdaki static yapılar,
uygulama bazında işlem yapmamızı,
yine uygulama bazında veri depolayıp
ve bu verilere erişebilmemizi sağlayan
evrensel noktalardır.

Nasıl ki dünyanın her noktasından
baktığımız güneş yine aynı güneşse,
yazılımda da static yapılar
uygulamanın her noktasında aynı
alanlara/yapılara karşılık gelecektir.

O yüzden biraz önce
söylediğim gibi static alanlarda
çalışmak için bulunduğumuz
sınıfın instance•ından ziyade
türüne ihtiyacımız yeterlidir.

BU metaforda: insanlar bir instance, her bir
insan içindeki göz ise o instance'ın bir
member'ıdır. Lakin hangi insanın
gözünden bakarsak bakalım göreceğimiz
güneş hepsi için aynı olacağından güneş
sialic bir yapı olarak yorumlanabilir.
 */
#endregion

#endregion

#region Uygulama Bazında Evrensel Nokta 'Static'
/*
 Static, uygulama bazında evrensel
çalışmalar yapabilmemizi
sağlayan yapıları ifade eden bir
kavramdır.

Bu kavramı daha net
anlayabilmek için RAM 'in yapısına
tekrar odaklanmamız
gerekmektedir.

Piograthiri çalışma süresi boyunca aynı
kalan, uygulama açısından evrensel
nokta olan: sabit verilerin, metotların ve
sınıf düzeyindeki değişkenlerin(field)
bulunabildiği bellek alanıdır.

Bu alandaki yapılara ya da verilere
ulaşabilmek için bir sınıf örneğine ihtiyaç
duyulmamaktadır, çünkü bu alanda
tanımlanan yapılar static yani sabit
olarak tanımlanmakta ve her yerden
erişilebilir olarak tanımlanmaktadır.

Dolayısıyla her yerden erişilebilir yapilar
olacaklarından ve yerine göre değişen
yapılar olmayacaklarından dolayı bu,
static alandaki yapılara erişim için s.nıf
örneğine ihtiyaç duyulmamaktadır.

Aynca genel kültür olarak bilmenizde
fayda var ki, RAM'de ki static alan
esasında Heap içerisinde
High Frequency Heap
olarak bilinen özel bir alana karşılık
gelmektedir.
 */
#endregion

#region Neden static yapılanmayı tercih ederiz
/*
 Static yapılanma, uygulama bazında
tanımlanan yapılar olduğu için,
uygulama açısından veri paylaşımını
kolaylaştırabilmektedir.

Misal olarak; uygulamanın herhangi bir
noktasında yapılandırma ayarlarına
ihtiyacımız olabilir. BU avcıriarj static
yapıp, uygular-na bazında tek seferde
tanımcıyabifirsiniz.

Ya da benzer mantıkla uygulamanın
staie(durum) bilgisini tutmanız
)gerekebilir. Bunun için de yine static
bellekten istifade edebilirsiniz,

Yani anlayacağınız, uygulamanın
herhangi bir noktasında değişmeyecek
bir şekilde kullanılacak olan verileri bizler
static bellekte tutmayı tercih
edebiliyoruz.

Bu bizlere bellek optimizasyonu ve
yönetimi açısından oldukça avantaj
sağlayabilmektedir.

Düşünürseniz, uygulama için her yerde
aynı olan yapılandırma ya da state
değerlerini Heap'te bir instance olarak
tutmak lüzumsuz bir maliyet olacaktır.

Tüm bunlann dışında static yapılanmalara,
sınıf örneğine ihfiyaç kalmaksızın
doğrudan erişilebileceğinden dolayı
Global Erişim süreçlerinde static
yapılanmalar tercih edilebilmektedir.

bu sınıf örneğine ihtiyaç
duyulmadığından dolayı nesne
bağımsızlığının söz konusu olduğu
davranışları static yapılanmalarla
_ gerçekleştirmek_ oldukça ideal ol caktır.

Static yapılar, uygulama seviyesinde verileri saklamak için kullanılmaktadırlar.
 */


#endregion

#region Static Bellekte Neler, Nasıl Tanımlanır?
/*
 Static bellekte; static field'lar, metotlar,
property'ler, constant'lar ve static iç sınıflar(inner
classes) tutulabilmektedir
 */

#region Static Fields
/*
Bir field static olarak tanımlanabilmekte ve böylece uygulama
seviyesinde merkezi olarak erişilip, kullanılabilmektedir.
Bir field'ı static belleğe koyabilmek için aşağıdaki gibi static
keyword'ü ile işaretlenmesi gerekmektedir.

static public int staticfield;

BU şekilde static field, compiler
tarafından static bellek üzerinde tanımlanmış olacaktır.
 */
#endregion

#region Static Methods
/*
 Metotlar da static olarak tanımlanarak, uygulama seviyesinde
merkezi işlevler olarak erişilip, kullanılabilmektedirler.
Metotlan static belleğe koyabilmek için imzalannın aşağıdaki gibi
static keyword'ü ile işaretlenmesi yeterlidir

static public int staticMethot{...}

BU static keyword 'ü ister access modifier'dan önce, isterse de
sonra belirtilebilmektedir.
 */
#endregion

#region Static Property
/*
 Property'ler de aynı şekilde static bellekte tanımlanabililiyorlar.
Yapılması gereken ilgili property'nin imzasını tıpkı metotlarda
olduğu gibi static keyword'ü ile işaretlemektir.

public static int StaticProperty { get; set; }
 */
#endregion

#region Constants
/*
 Constant'lar özünde static yapılanmalardır. (Bundan temel
programlamada bahsetmiştik. Haliyle bir sınıf içerisinde
tanımlanmış olan constant otomatik olarak static bellekte
oluşturulacaktır. Bundan dolayı constant tanımları static
keyword'ü ile işaretlemek mecburiyetinde değilsiniz. Zaten işaretleyemeyiz de zaten static 
 */
#endregion

/*
 Static bellekte tutulan yapılar,
hangi sınıfta tanımlandılarsa, o sınıf
adına karşılık tutulmaktadırlar.

Bundan dolayı static bellekteki
herhangi bir yapıya erişim
göstermemiz gerekiyorsa eğer
sınıf isimleri kullanılmaktadır.

MyClass.StaticMethod(); gibi kullanılmalıdır

Görüldüğü üzere sınıf ismi
üzerinden .(nokta) operatörü
aracılığıyla, o sınıfta tanımlanmış
olan tüm static yapılanmalara
erişebilir ve istediğiniz gibi
kullanabilirsiniz.

Peki sınıfın nesnesi
üzerinden erişebilir
miyiz hocam?

Tabi ki de hayır, static yapılara
instance'lar Üzerinden erişilememktedir
 */

#region Static yapılar nasıl kullanılır
using System.Runtime.CompilerServices;

MyClass.StaticProperty = 12;

MyClass.Staticfield = 13;

MyClass.StaticMethod();

Ahmet.StaticMethod();

Console.WriteLine(MyClass.constant);
/*
 Yanı burada Console.Writline() --> buradakı Writline statıc bellekten geldıgını soylıye bılırız cunku consol sınıfından nesne uretmıyoruz 
 */
#endregion

class MyClass
{
    static public int Staticfield;
    public int NonStaticfield;

    public void NonStaticMethod() { }
    public static void StaticMethod()
    {
        //Bu methot sade ve sadece satatic olan lara erişim saglıya bılır
        Staticfield = 12; //erişebilir
                          // NonStaticfield = 12; //Erişemez hata verır statıc degıl
    }

    public int nonStaticProperty { get; set; }
    public static int StaticProperty { get; set; }

    public const int constant = 0;


}

class Ahmet
{
    public static void StaticMethod() { } //Yukarıdakı ıle bu aynı degıldır sınıf adına ozgu olusutur bu statıc method u
}
#endregion

#region Static Elemanların Genel Kuralları
/*
 ---> Kural 1 (Static Anahtar kullanılması)
    Bir yapıyı(field, metot, property veya Class) static
    yapmak için 'static' keyword'ü ile işaretlemek
    gerekmektedir.

---> Kural 2 (Genel Erişim)
    Static yapılara sınıfların nesneleri üzerinden
    erişilemez! Doğrudan sınıfların adlarından erişim
    sağlanabilir.

-->Kural 3 (Stafic Elemanlarda Satic Olanlara Erişim)
    Static yapılar içerisinden sade ve sadece static
    elemanlara erişim gösterilebilir. Ama bu durumun
    tam tersi geçerli değildir, yani static olmayan bir
    eleman, static olan erişebilmektedir.

-->Kural 4 (Static Classlar )
    Eğer ki bir class static keyword'ü ile işaretleniyorsa o
    class içerisindeki tüm member'lar static olmak
    zorundadırl Ayrıca o sınıfta constructor
    tanımlanamaz ve o sınıftan nesne oluşturulamaz!

-->Kural 5 (Overload Edilebilir ve Override Edilemez)
    Static metotlar overload edilebilir lakin override (kalıtımlar la alakalı)
    edilemez , virtual ile işaretlenemez!

-->Kural 6(Lifetime)
    Static yapıların ömrü, uygulamanın ayakta kaldığı
    süre, yani uygulamanın ömrü kadardır.
 */

/*
 Sınıfı static yapar ısek sınıf statıc bellege atılmaz 
sınıf ıcerısındekı elemanların hepsının sıtatık olmasını garanti eder
bu sındftan nesne olusturulamaz ve ctor kullanılamaz
 */

static class asfafs
{
    // public int MyProperty { get; set; } //Hata verır
    static public int MyProperty { get; set; }
}


class MyClassa
{
    private static string a = "asfasffs"; //sadece bu sınıftan erişilir

    public static void StaticMethod()
    {
        a = "asfasf";
    }
    public static void StaticMethod(int s) //statıc methot overload edıldı
    {
        a = "asfasf";
    }


    // virtual private static string b = "asfasffs"; //statıcler virtual ıle ısaretlenemez ler kalıtımla alaklı bısey bu 
}

#endregion

#region Static sınıfların kalıtımsal ilişkilesi nasıldır?

/*
 KALITIMSAL iLişKi, SINIFLARIN INSTANCE' ÜZERİNDE DAVRANIŞ GERÇEKLEŞTİRDİĞİ içiN STATİC
CLASS'LAR DA INHERITANCF DAVRANIŞI MÜMKÜN DEĞİLDİZ!
 */

class MyClaasss
{
    public void A()
    {
        MyClass2.MyProperty = 1; //erişilir
    }
}

class MyClass1
{
    public static int MyProperty { get; set; }
}

class MyClass2 : MyClass1
{

}

//1 statıc class var ise kalıtımı unut 
/*
 sattıc-class
 static-static
 static-Interface

olmaz bunlar
 */
static class MyClassasf
{

}


#endregion

#region Static Member'lar Protected ile İşaretlenebilir mi?
/*
 C# PROGRAMLAMA DİLİNDE, 'PROTECTED' İLE İŞARETLENMİŞ HERHANGİ BİR MEMBER'A, SADE VE
SADECE O MEMBER'IN TANIMLANDIĞI CLASS'TAN TÜRETİLMİŞ OLAN ALT SINIFLARDAN ERİŞİM
GÖSTERİLEBİLMEKTEDİR. DOLAYISIYLA 'PROTECTED' KALITIMSAL iLişKi GEREKTİREN BİR ACCESS
MODIFIER'DIR.
 */

/*
 .NET'te miras olayları yalnız instance
tabanında çalıştığından dolayı
herhangi bir static member'ı protected
ile işaretlemek bu açıdan manasız
olacaktır. Amma velakin, normal
sınıflarda tanımlanmış olan static
member'lan protected olarak
işaretlersek, bu durumda, o static
member'lara, sadece ilgili sınıftan
türeyen alt sınıflar üzerinden erişim
gösterebileceğimiz lakin sınıf türleri
üzerinden erişemeyeceğimiz anlamına
gelmektedir.
 
 */
class MyClassasfas : sadasf
{
    public void A()
    {
        sadasf.MyProperty = 12;
    }
}

class sadasf
{
    protected static int MyProperty { get; set; }
}
/*
 Eğer ki, bu static elemanı protected ile işaretlememiş
olsaydık, buradaki kalıtımsal ilişki neticesinde
MyProperty'e MyCIass2'den erişebiliyor ve biryandan
da hem MyCIass hem de MyClass2 türleri üzerinden
de erişim gösterebiliyor olurduk. işte, protected
sayesinde static bir member'a sadece kalıtımsal
durumdaki alt sınıf içerisinde erişim sınırı getirmiş
oluyoruz..
 */

#endregion

#region this Keyword'ünün Static Metotlar ile ilişkisi
/*
 BİR INSTANCE İÇERİSİNDE O INSTANCE'I TEMSİL EDEN THIS KEYWORD'(JNE, STATIC METOTLARDAN
ERİŞİLEMEZ!
 */
/*
 Static olmayan
member'larda hem static
olan hem de olmayan
tüm member'lara
erişilebilir.

Lakin static olan member'lar da
sadece static olan
member'lara erişilebilecektir.
Bundan dolayı instance ile
alakalı olan this keyword'üne
de erişim mümkün değildir!
 */

class asfsaaggas
{
    static public void a()
    {
        // this.  --> burada da this kullanılamaz hata verir static olamamsı lazım kullana bılmek ıcın 
    }
    public void basf() { }

    public asfsaaggas()
    {
        a(); //erişim vardır 
             // this.a();//erişim yoktur hata verir
        this.basf();    //erişim vardır
    }
}
#endregion

#region Static Yapılar ile Nesneler Arasındaki Farklar Nelerdir?
/*
 Static yapılar ile nesneler arasında
önemli farklar mevcuttur ve bu farklar,
C# ve diğer nesne yönelimli
programlama dillerinde sıkça karşılaşılan
kavramlardır.
 */
/*
 
---->İlk Oluşturma Zamanı
    Static Yapılar : Sınıfın uygulamada yüklendiği an ve ilgili sınıftan
herhangi bir nesne oluşturulmadan önce oluşturulurlar.

    Nesneler : Developer tarafından bir instance talebi geldiğinde
oluşturulurlar.

---->Ömür
Static Yapılar : Uygulamanın yaşam ömrüyle doğru orantılıdır.
Uygulama başladığında oluşturulur ve sonlandırıldığında yok olurlar.

Nesneler [ Öluştuİüidukları scopla kendilerini işaretleyen 
referansın varlığıyla sınırlıdırlar. Aksi taktirde bir müddet sonra imha
edilirler.

--->Erişim
Static Yapılar : Tanımlandıkları sınıfın adından, uygulamanın herhangi
bir noktasında erişim gösterilebilir.

Nesneler : Sınıfın instance' ının oluşturulmasıyla ve referansını elde
tuttukça erişilebilir.

--->Verisel Paylasım
Stafic Yapılar : Sınıfın kendisi veri olarak değerlendirilir ve bu veriler
uygulama çapında, tekil olarak tutulmaktadır.

Nesneler : Her nesne kendi özel verisini tutmaktadır ve tanımlandıkları
yahut referanslı oldukları faaliyet alanları çapında erişilebilir.

--->Faliyet alanı
Static Yapılar : Uygulama çapındadır.

Nesneler : Tanımlandıkları veya referans edillebildikleri metotlarla
sınırlıdır.
 */
#endregion
#region Static Constructor
/*
 Biliyorsunuz ki, C#'ta sınıfların static
constructor mevcuttur. Bunu OOP I .
Etap eğitimlerinde tam teferruatlı
değerIendirmiştik.

Bizler bu s atic constructor ile, ilgili sınıfta
tanımlanmış olan bir static yapının ilk kullanılması
ya da o sınıftan ilk nesne oluşturulması sürecinde
bir kereye mahsus tetiklenmesiyle belli işlemler
gerçekleştirebilmekteyiz.

Slatic constructor; yapısal olarak
otomatik çalıştırıldıklarından dölavt
deveıoper tarafından doğrudan
çağrılıp, çatıştırılamaz.

Tanımlandıkcın sınıftan nesne oluşturma
ya da o sır-i[ftaki herhangi bir static yapıyı
tetikleme sürecinde bir kereye mahsus
çalışacağı için parametrik bir
yapılanmada değildir!

Vee genellikle Stufic constructor, sınıl içerişinde
tanırnianmış olan siatic eiemaniorıvy başlangıç
değer*erini atayabilmek ve bunu bir kerye
mahsus yapabilmek için kullanılmaktadır.
 */
class asfasggasas
{
    public static asfasggasas afs;
    static asfasggasas()
    {
        afs = new();
    }
}

#endregion

#region Static Local Functicn
/*
 7.0 ile gelen Local Function özelliği
8.0 ile static özellik kazanmış
vaziyettedir.

Bizler bir metodun içerisinde Non Static
Local Function tanımlayabildiğimiz gibi
Static Local Function'da
tanımlayabilmekte ve işlemlerimizi
yürütebilmekteyiz.
 */


class Deneme
{
    static int a = 3;

    public void X(int b = 5)
    {
        int c = 7;
        Y();
        Z(b, c);

        void Y()
        {
            Console.WriteLine($"{a}-{b}-{c}");
        }

        static void Z(int b, int c)
        {
            //Burada statik olmayanları kullanmak ıcın parametreden ala bılırız
            Console.WriteLine($"{a}-{b}-{c}");
        }
        /*
        Static Loca! Function'larda, yerel
        değişkenlere erişim engellenmiştir lakin
        stafic yapılara erişim direkt
        sağlanabilmektedir. Haliyle yerel
        değişkenlerin değerlerini parametreler
        aracılığıyla Static Local Function içerisine
        aktarabilmekteyiz
         */
    }
}

#endregion