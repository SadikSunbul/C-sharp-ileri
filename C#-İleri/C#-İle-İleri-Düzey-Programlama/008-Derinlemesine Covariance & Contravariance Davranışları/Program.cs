
#region Derinlemesine Covariance & Contravariance Davranışları

#region Giriş
/*
//int i = 3;
//string s = "asd";
//char c = 'a';

// -->Polimorfizim
using System.Security.AccessControl;

A a = new B();

// -->Covariance  Buyuk bır turun dızısıne kucuk bır turun dızısını atıyabılırsek buna Covariance deriz
object[] isimler = new string[5] { "Ahmet", "Mehmet", "Hilmi", "Rıfkı", "Şuayip" };

// -->Covariance
A[] aArray = new B[5];

// -->Covariance
IEnumerable<object> arabalar = new List<string>() { "opel", "toyota", "mercedes" };

// -->Covariance
IEnumerable<A> asd = new List<B>() { new(), new() };

// -->Covariance
Func<A> funcA = GetB;
B GetB() => new();



// -->Contravariance
Action<string> xDelegate = Xmethod;
void Xmethod(object o) { }

// -->Contravariance  Kucuk tur buyuk turu karsılıyor burada 
Action<B> bDelegate = AMethod;
void AMethod(A a) { }

*/
#endregion


#region Nedir Bu Covariance ve Contravariance Denen Şeyler?
/*
Covariance ve Contravariance terimleri;
array types, delegatetypes, return
types ve generic types için
örtülü/implicit referans dönüşümlerini
ifade eden özelliklerdir,

Şimdi bu terimleri daha iyi bir şekilde
anlayabilmek için atama uyumluluğu
dediğimiz assignment compatibility'i'
ele alalım.

B A dan turer
A a=new B(); 

Burada A türünün B türünü
karşılayabilmesi Polimorfizim
kuralları gereği geçerli
olacaktır. Biz buna atama
uyumu demekteyiz.

Covariance ve Contravariance özellikleri
sayesinde bu atama durumuna benzer tür
dönüşümlerini; array, delegate, return ve generic
types için biraz önce de söylediğimiz gibi implicit
bir şekilde gerçekleştirebilmekteyiz.

Covariance ve Contyâûaçiance
terimlerinin programatikaçıdan ne
olduklarını het bir şekilde anlayabilmek
için öncelikle isimler.ininânlamlarından
yola çıkalım istiyorum.

BU kavrâmlarjrğ kökü matematikten
gelmektedir. Şöyle ki;

 */
#region Covariance
/*
 Covariance, matematikte iki değişkenin birlikte nasıl
değiştiğini ifade eden bir terimdir. İki değişken aynı yönde
değişiyorsa eğer bu duruma Covariance denmektedir. Yani
biri artıyorken, diğeri de artıyor demektir.

'C#'ta Covariance, daha spesifik olan bir türün
daha genel bir türün yerine kullanılabilmesi
anlamına gelmektedir. (erkegı ınsana atama gibi)


A a=new B(); //Bu polimorfizimdir Covariance değildir

IEnumerable<B> b=new List<B>();
IEnumerable<A> a = b; //bruası Covariance dir

İşte buradaki davranış •
Covariance'dır. Dikkat
derseniz, türetilmiş olan
B tipi, atası olan A tipine
atanabilmektedir.
 */


#endregion

#region Contravariance
/*
 Contravariance'da yine matematikte iki değişkenin
birbirine karşı nasıl değiştiğini ifade eden bir terimdir. BU'
sefer iki değişken birbirine karşı farklı yönde değişim
gösteriyorsa, yani biri artıyorken diğeri azalıyorsa bu
duruma Contravariance denmektedir.

C#'ta Contravariance, daha genel bir türün
daha spesifik bir türün yerine kullanılabilmesi
anlamına gelmektedir. (insanın erkege kullanılması gibi)

B b=new A(); //bu polimorfizim den dolayı zaten olmaz hata verir ki zaten buradki Contravariance bu değildir

void method(A a) { }
Action<A> ADelegate = method;
Action<B> BDelegate = method; //burada Contravariance var cunku A turu B referansı verılebılır

Burada da; miras v@ren A
türü, miras alan B türüne
atanabilmektedir. İşte bu
Contravariance'dır.

 */


#endregion

/*
 Bura dikkat ederseniz;
Covariance özelliği
atanıp uyumluluğunu
assignment compatibility)
korurken, Contravariance.
ise bunu tam tersine
çevirmektedir.
 */

#endregion


#region Covariance
//Covariance-Kullanıldığı Durumlar
#region Array Types
/*
 Alt türden oluşan biç dizinin,
üst türden olan bir diziye implicit bir
dönüştürülmesi durumudur.

Animals[] animals=new cat[3];
clas Animals{}
clas cat:Animals{}

    object[] obj=new string[5];
    BU yöntem,
    anlaşılacağı üiere
    tür açısından pek
    güvenli değildir. 

ornk;
onject[] x=new string[]{"sadik","ali","ahmet"};
x[0]="Osman"; //olur
x[1]=12; //suan hata vermez ama derleme sırasında hata vermez ama runtime da hata vericektir burası ne kadar object te olsa aslında arkada string çünkü string degerili diziyi tutuyor
 */
/*
 Aynı şekilde üst türden
tanımlanmış 015n 1Enumerable
referansına da alt türden bir
dizi atanabilmektedir.

IEnumerable<Animals> animals1=new List<cat>();
IEnumerable<Animals> animals1=new cat[5]();
 */

#endregion

#region Delegate Types
/*
 Covarianceı metotların temsil
edildiği delegate'lerde de
kullanılabilmektedir.

elegate'lers dece eşleşdikleri imzalara sahip
olan metotları değil, aynı zamanda delegate'in
kullandığı return type'dan türgrniş olan türleri
return type olarak kullanan metot imzalarını
da işaretleyebilmektedir.

func<Animal> getAnimal=GetCat;
Cat GetCat()=>new();
 */
#endregion

#region Return Types
/*
 Covarianceı override edilmiş metotlarda
da geçerliliğini korumakta, metodu
override ederken return type'ı base
class'ta kullanılan türden türetilmiş
darak tanımlayabilmektedir.
 */
/*
class Animal
{
    public virtual Animal GetAnimal() => new();
}
class Cat:Animal
{
    public override Cat GetAnimal() => new(); //buradaki overieyi aslında Animal türde olmasını bekleriz ama burada Cat de yapıla bilir burada Covariance dönüşümğ vardur 
}
*/
/*
 Covariance'ın override
durumlarındaki bu
davranışıC# 9.0'da
gelmiştik.
 */

#endregion

#region Generic Types
/*
 Covariance özelliğinesahip olan--
generic tür parametresi oluşturmak .
istiyorsak eğer ilgİK tür parametresini
0Ut keyword'ü ile işaretlemşmiz
gerekmektedir.
 */

using System;

IAnimal<object> animal = new Animal<string>();
IAnimal<A> aAnima = new Animal<B>();
interface IAnimal<out T> { } //nurada out olmazsa Covariance kullanılmaz 
class Animal<T> : IAnimal<T> { }


/*
 Generik ıfadelerde out un kullanılması sade ve sadece İnterace ve delegatelerde olur bır sınıfta kullanamazsınız hata verır 
 */

//Delegate için 
Console.WriteLine();

XDelegate<A> a = getA;
XDelegate<A> b = getB;

a = b;

A getA() => new();
B getB() => new();
delegate T XDelegate<out T>();

/*
 BU 0Ut keyword'ü
;sayesinde buradaki a=b
komutu hatasız
derlenebilmekte ve üst
türle tanımlanmış a
deleğate'ine, alt tür ile
anımlanmış b delegate'i
atanabilmektedir.
 */

#endregion

#endregion

#region Contravariance
//Covariance-Kullanıldığı Durumlar

#region Delegate Type
/*
 Contravariance davranışı
delegate'ler de sıkça
görülmektedir:
Bir delegate ın,tanımlandıgı 
türden daha genel bir turun 
imzasını kabûl etmesi durumudur.
 */
Console.WriteLine();
Action<A> aAction = a => { };
Action<B> bAction = aAction; //KUCUGE BUYUGU VERDIK 
#endregion

#region Generic Types
/*
 Contravariamçe davranışına sahip
olan generic tür parametresi
luşturmak istiyorsak eğer bu sefer
dâ ilgili tür parametresini in
keyword'ü ile işarettemeliyiz!
 */
Console.WriteLine();

IDenemeAnimal<B> bdeneme = new DenemeAnimal<A>(); //Contravariance
IDenemeAnimal<B> bdeneme2 = new DenemeAnimal<B>();
IDenemeAnimal<string> bdeneme3 = new DenemeAnimal<object>();//Contravariance
interface IDenemeAnimal<in T> { } //in keywordunun olması lazımdır Contravariance yapmak ıcın 
class DenemeAnimal<T> : IDenemeAnimal<T> { }

//Delegate lerdede aynı 
Console.WriteLine();

XDelegates<B> a1 = getA1; // b ye a yı attık  tam tersı hata verır cunku ınyaptık out yapsak tersı olurdu 
XDelegates<B> b1 = getB1;

a = b;

void getA1(A a) { }
void getB1(B b) { }
delegate void XDelegates<in T>(T t);
#endregion

#endregion

#endregion

#region Kritik 
/*
 Delegate'ler de; covariance davranışi(out) adı üzeiinde output pozisyonlarında kullanılırken,
contravariance davranışı ise (in) benzer mantıkla input pozisyonlarında kullanılır!
 */
delegate void XHandler<in T>(T t); //input returnde T turunu kullanamayız
delegate T XHand1er<out T>(); //output donus turu T olmalıdır ve parametre T olmaz
#endregion

#region Variance' lapın Polimorfizm Davranışına Benzerliği
/*
 Evet, variance davranışlarıyla
polimorfızm arasında benzerlik
durumu söz konusudur!

Polimorfizm, bir nesnenin
farklı türlerle kullanılabilme
yeteneğini ifade etmektedir.

„Variance'lar ise; spesifik bir türün daha genel bir tür yerine
kullanılabilmesi olan Cavariance ile, tam tersi olan daha
genel bir türün daha spesifik bir türün yerine-
kullanılabilmesi olan Contravariance davranışlarından
ibarettir.

Haliyle her iki variance açısından olayı
değerIendirdiğimizde polimorfizm'in farklı
Âavranışlarını gözlemliyor olacağız...

Covariance açısından
polimorfizm'in daha da
gelişmiş bir ürantş söz
konusudur diyebilitiz.

Yani covariance ile daha genel türlerin, daha spesifik alt
türleri karşılamasıyla polimorfizmin temel özelliği
sergilenebilmekte ve böylece özellikle generiç türlerde,
koleksiyonlar da ve delegate'ler de polimorfizim kuralları
gereği davranışlar sergileyebilmemizi sağlamaktadır.

İşte bundan dolayı covarian•ce ile C#'da ki
polimorfızm daha güçlü ve esnek hale
getirilebilmektedir.

Contravariance'da ise gendi türlerin, daha
spesifik bir türün yerine kullanılabilmesi ile
türlerin hiyerarşi açısından yukgrı doğru takip
etmesi sağlanabilmektedir.
 */
#endregion

#region Hazır Variance Olan Generic Interface' ler
/*
 IEnumerable<T>
 T is covariant

1Enumerato<T>
T is covariant

lQueryable«T»
T is covariant

ICompare«T»
T is contravariant

IGrouping«TKeyı,TElement»
TKey and Telement are covariant

IComparable«T»
T is contravariant

IEqualityCompare«T»
T is contravariant

IReadOnıyList«T>
T is covariant

IReadOnlyCollection«T»
T is covariant
 */
#endregion

class A
{

}

class B : A
{

}