
#region Implicit & Explicit Operators Nedir?
/*
 BU sağ sol kuralı her ne kadar
temel kural olsa da,
polimorfizm kuralları gereği
esnetilebildiğini ve daha
geniş türler tarafindan alt
türlerin referans
edilebildiğini biliyorsunuz.

Yani kalıtımsal ilişki olduğu sürece
sağ sol kuralı geçerliliğini
koruyabilmektedir.

Peki, herhangi bir kalıtımsal durumun
olmadığı yani plimorfizm kurallarının
geçersiz olduğu veri türleri arasında bu
denklemi sağlarsak ne olur? 
El cevap, beklendiği üzere
derleyici hatasıyla
karşılaşılacaktr.

Ha yok yıne de polimorfizm kulları
olmaksızın atama sürecinde farklı türleri
birbirlerine atayabilelim istiyorsanız, bu
durumda yapabileceğimiz tek şey gizli ya da
açık bir tür donüşumü gerçekleştirmek
olacaktır.

işte bunu yapabilmek için implicit ve explicit
kavramları devreye girmektedir!

Şimdi implicit ve explicit nedir sorusuna cevap
vermeye çalışırsak eğer; bir verinin, kendi türünden-
olmayan farklı bir referansa yahut değişkene
atanabilmesi için, atanma surecinde yapılan tür
donüşturme işlemlerini açıklamak için kullanılan
kavramlardır.
 */


#endregion

#region Implicit Conversion (Kapalı Dönüşüm)
/*
 Implicit Conversion, bir verinin kendi turünden
olmayan veri tünjne atama surecinde otomatik
olarak dönüştürülmesini ifade eder.  

_A_ = _B_
Aha şistss layn! A türünden bir değişkene B türünden bir değer atamaya çalışyor!

La tamam olum, telaş etme! Çaktırmadan biz B'yi A türüne dönüştürelim! Herkes ekmeğine baksın!


Normalde B türünden değer, A türünden bir
değişkene atanamazken; implicit conversion
sayesinde bu işlemi syntax açısından geçerli
kılıyor ve B'nin A'ya donüşumünu gizli/kapalı bir
şekilde gerçekleştirebiliyoruz.

Burada gerçekleştirilen donüşüme gizli/kapalı denmesinin sebebi, bu
donüşümü developer'ın iradesiyle gerçekleştirmemesi ve compiler
tarafindan otomatik olarak sağlanmasıdır. Eğer ki, A ve B türleri arasında
implicit donuşüm kurallarına uygun birtanımlama varsa(ki ileride
göreeceğiz) o taktirde developer bl.i syntax'ta bir atama ifadesi
yazabilecek ve herhangi bir donüşıjm yapmaya gerek duymaksızın(yani
hata almaksızın) yoluna devam edebilecektir.
 */
#endregion

#region Explicit Conversion(Açık DönÜşüm)
/*
 Explicit Conversion ise bir verinin, kendi türünden
olmayan farklı bir veri türünden değişkene atanma
sürecinde iradeli/açık bir şekilde dönüştürülmesini
ifade eder.

_A_ = (A)_B_   seklınde cast etmek lazımdır

Görüldüğü üzere B türünden değenmzi A turüne Cast ediyor ve boylece bilinçli bır dönüşüm sağlamış oluyoruz.

Burada da normalde B türünden değer, A
türijnden bir değişkene atanamazken; explicit
conversion sayesinde bu işlemi syntax açısından
geçerli kılıyor ve B'nin A'ya açık[ıradeli bir şekilde
gerçekleştirebiliyoruz.

Burada gerçekleştirilen donuşume açık denmesinin
sebebi, bu donuşumun developer'ın iradesiyle
gerçekleştirilmesidir. Eğer ki, A ve B turleri arasında
explicit donüşum kurallarına uygun bir tanımlama
varsa(ki ileride goreeceğiz) o taktirde developer bu
syntax'ta bir atama ifadesi yazabilecek ve yoluna
devam edebilecektir.
 */
#endregion

#region Implicit & Explicit Dönüşümlerin Temel Programlamadaki Yeri
/*
 Hatırlarsanız temel programlamada bizler büyük
sayısal türlerin, direkt olarak küçuk sayısal
türlerdeki değerleri karşılayabildiğini ve bu
durumun tam tersinin ise iradeli bir şekilde
mümkün olabileceğini incelemiştik.

    int=short
    int=byte
    long=innt
    float=long

Normal şartlarda sağ sol kura gere ı
farklı türlerin birbirlerini
karşılamaması lazımken usteki
ömekte olduğu gibi küçük sayısal veri
türlerini büyük türlerin karşılaması
özünde bir implicit davranışıdır!
Yani iradesiz/gizli/kapalı bir şekilde
esasında küçük veri türleri büyük veri
türlerine dönüştürülmektedir!

    short=(short)int
    byte=(byte)int
    int=(int)long
    long=(long)float

Ve hatırlarsanız büyük veri türünden
Olan değerlerin küçük veri türlerine
atanması için geliştiriciden bu konuda
bir irade istenmesi yani cast
operatörüyle bilinçli bir dönüşüm
gerçekleştirilmesi explicit
davramşımn ta kendisidir!

Yine anımsayacağınız üzere kapalı tür
dönüşümü genellikle veri kaybı olmayacak
durumlar için geçerliyken, açık tür dönüşümü
ise veri kaybı riskinin söz konusu olduğu
durumlarda kullanılmaktadır ki veri kaybı
olursa bunun sorumluluğu geliştirici
tarafından üstlenilsin..


Yani anlay cağınız, implicit ve explicit tür
dönüşümleri özünde programlamanın
temellerinden beri hayatımızda olan kavramlardır
amma velakin biz farkında değildik! Taa ki kendi
türlerimizde bu dönüşümlere ihtiyaç duyana
kadar 
 */
#endregion

#region özel Türlerimizde Implicit & Explicit Tür Dönüşümleri Nasıl Gerçekleştirilir?
/*
 Kendi özel türlerimizde implicit ve explicit tur
dönüşümlerini gerçekleştirebilmek(destekleyebilmek)
için bu operatörlerin overloading edilmesi
gerekmektedir!

class A
{
public int AValue{get;set;}
}

class B
{
public int BValue{get;set;}
}

A a=new();
B b=(B)a; //yapılamaz suanda hata verır 

Şimdi yukarıdaki sınıflan ele alırsak eğer normal
şartlarda bunların birbirlerinin referanslarına
atanması teknik olarak mijmkün değildir!

Şim i bu donüşümlerin gerçekleşmesi için heri i
sınıftan birinde implicit ve explicit operatörlerinin
overloadıng edılmesı gerekmetedir


 */
#region Tabi şimdi oncetikle bu operatörlerin overloading yapısını inceleyelim.
/*
 public static implicit/explicit operstor A(B b)
{
return new A(){A.property=B.property};
}
düğü üzere implicit ve explicit operatörlerinin overloading'i static bir member
tanımryla gerçekleştirilmektedir. Ve biryandan da bu membeeın public olması zaruridir!

Hangi overloading ediyorsak onun keyword'ünün buraya bildirilmesi gerekmektedir.

Ardından operator keywordü eşliğinde bunun bir oşwatör överloading tanımlaması olduğu ifade edilmelidir!

Görüldüğü üzere A ve B türleri de
tanımlanmaktadır. Burada implicit ya da
explicit hangisi overloading ediliyorsa
edilsin, hangi türün hangi türe
dönüştürüleceği ifade edilmektedir.

BU ifade B türünün A'e
dönüştürüleceğini yani
sonuç olarak B
nesnesinin dönüleceğini
ifade etmektedir!

İşte kendi özel urlerimizde, implicit veya explicit
tür donüşümleri bu syntax üzerinden overload
edilerek davranışa donüştürijlmekte ve
kullanılmaktadır. Şimdi gelin soldaki A ve B
sınıfları üzerinden verdiğimiz örneği bu syntax
şablonu üzerinden gerçekleştireli

Misal olarak ben A ile B türleri
arasındaki donüşümü B sınıfı içerisinde
tanımlamak istiyorum.

Sen istersen A'da istersen de implicit'i
B'de explicitfi A'da tanımla...
Farketmez!
 */

#endregion
#endregion

#region Örnek

//Burası çok onemlidir !!!
/*
 şimdi bır sınıfımız ıcerısınde implicit kullandık B turunu A ya donduruyor bunu soyle kullanabiliriz
    A a=new B();
    A a=(A)new B();
bu ıkı sekılde yapılabılır yanı implicit explicit ı de karsilar bunuun tam tersı olmıycaktır  explicit kullanmıs olsaydık yanı bu donusum 2. dekı gıbı olması gerkeırdı 1. yı desteklemez

yanı kapalıyı acık olarakda donusturebılrıız
ama acıgı kapalı olarak donusturemeyız
 */

A a = new B();
A a2 = (A)new B();

B b = (B)new A();
class A
{
    public int inta { get; set; }
    public static implicit operator A(B b)
    { //B yi a ya dondur
        return new A() { inta = b.intb };
    }
}
class B
{
    public int intb { get; set; }
    public static explicit operator B(A a)
    { //A yı b ye dondurur
        return new B() { intb = a.inta };
    }
}
#endregion

#region Implicit ve Explicit Dönüşümlerde Performans ve Best Practices
/*
 Implicit ve explicit donuşümler C# programlama
dilinde, ileri düzey operasyonlarda yaygın olarak
kullanılan yapılanmalardır.

Ancak, bu oçwatörleri performans ve best
practice konularını goz onunde bulundurarak
kullanmak önemlidir.

işte implicit ve explicit donüşumlerin performansı
ve best practice'leri hakkında bazı bilgiler;


-->Performans
Implicit ve explicit dönüşümlerin performansı, modem derleyicilerin
genellikle bu tür dönüşümleri otomatik olarak optimize etmelerinden.
dolayı genellikle büyük bir endişe kaynağı değildir. Ancak, dönüşüm
süreçlerinde karmaşk operasyonların performansı etkileyebileceği
unutulmamalı ve bu tür durumlara karşın gereksiz dönüşümler yahut tür
dönüşüm zincirleri oluşturulmasından kaçınılmalıdır!

-->Kullanım Hasassiyeti
Implicit dönüşümlerin kullanımı, kodun okunabilirliğini
azaltabilmektedir, BU nedenle implicit dönüşümler mümkün mertebe
dokümante edilmeli ya da dönüşümün açıkça görünmesi ve yanıltıcı
durumların en aza indirilebilmesi için explicit dönuşumler tercih
edilmelidir.

-->Nullable Kontrolü
Implicit ve explicit dönüşümlerde, nullable değerlerle çalışma
yapılıyorsa eğer beklenmedik hataların önüne geçebilmek için null
yerine geriye uygun bir varsayılan değer döndürmenizi tavsiye ederiz.

-->Kullanıcı Tanımlı Dönüşümler
Kendi oluşturduğunuz özel sınıflarda implicit ve explicit dönüşümleri
kullanırken, olabildiğince mantıklı, güvenli ve beklenen sonuçlan
uretebilecek bir tanımlama yapmaya Özen gösteriniz.
Kullanıcı(developer) açısından kodda yapılan işlemin anlaşılabilirliği ve
beklenmedik sonuçlarla karşılaşmaması için dikkatli olunmalıdır!

-->Test
Özellikle karmaşık yahut kritik dönüşüm işlemlerinin beklenen sonuçlan
üretip üretmediğinden emin olmak için sık testler yapılmalıdır.

-->Optimizasyon
Genel olarak, implicit ve explicit dönüşümlerin maliyetleri
ihmal edilebilir, ancak programınızın performans gereksinimleri
yüksekse ve belirli dönüşüm işlemleri bu performansı etkiliyorsa, bu
dönüşümleri manuel olarak optimize etme ihtiyacı olabilir. BU durumda,
öncelikle performans analizi yapmalı ve yoğun kullanılan dönüşüm
işlemleri optimize edilmelidir.

 */
#endregion
