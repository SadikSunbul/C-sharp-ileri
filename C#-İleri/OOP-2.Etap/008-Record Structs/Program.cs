


#region Record Structs

/*
 Record Struct Nedir?
Record Struct'ı anlayabilmek
için öncelikle Record yapısını
hatırlamakta fayda vardır.

Record'lar, verişel olarak taşıdıkları değerleri
ön planda tutan, değeri değiştirilemeyen ve
compile neticesinde 1Equatable«T»
implemente ederek özünde bir sınıfa dönüşen
referans türlü veri yapılarıdır.

Record Struct'lar ise
Record'ın birçok avantajını
sağlayan lakin değer türlü
olması gibi radikal farkları
olan veri yapılarıdır.

Bir record struct'ı oluşturmak
oldukça basittir.

record struct myRecordStruct
{

}

Nasıl ki bir record özünde tüm sınıf
özelliklerine sahip olan bir yapıysa,
benzer mantıkla bir record
struct'ta yine özünde bir struct
olan ve struct'ın tüm özelliklerine
sahip olan bir yapılanmadır.
 */

//----> Immutability

//Positional record altadır

Deneme deneme = new(1, "as");

// deneme.a = 23;  //-> hata verır ınıtonly propertyy cunku struct yaparsak ılgılı recordı bu durumda dırekt deger atıya bılırız buradan

RRstruct rRstruct = new RRstruct(132,"qw");
//rRstruct.c = 12; //normal struct gıbı olur cunku readonly olarak ısaretledıımız ıcın ınıt olur degıstırılemez degerı degısıtrmek ıcın altakıgıbı kullanıla bılır 

//-->With Expressios
var rRstruct1 = rRstruct with { a=12,b="asf" }; 

record Deneme(int a, string b) 
{

}

readonly record struct RRstruct(int a, string b)
{

}
/*
 BU positional record' Ionn en önemli özelliği değiştirilemez olmalarıdır. Çünkü
burada tanımlanan değişkenler özünde init property olarak üretilmektedirler.
Amma velakin positional records özelliği record struct'ta kullanılıyorsa eğer
değiştirilemez değildirler!(değiştirilebilirler yani)
 */

// --->With Expressios
/*
 yapamadığımız için ilgili nesneyi klonlayarak(deep copy) istediğimiz yeni
değerlerde yeniden oluşturmamm sağlayan bir özelliktir. Hafiyle record
class' lar do olduğu gibi record struct' lor da da with expression nitefiği
kullanılabilmektedir.
 */

//--->Equality Comparison(EşitIik Karşılaştırması)
/*
 Normal sartlardad struct veri turlerının uzerınde (==) eşit veya (!=) eşit değil operatorlerı desteklenmemektedir

Lakin record struct'lar da
bu operatörler
desteklenmektedir! BU da
radikal yeniliklerden birisidir!
Tabi burada verişel
değerler ön planda
tutulduğu için aynı
değerlere sahip iki farklı
record nesnesinin bu
şekilde karşılaştırılması true
değerini döndürecektir.

if(m1==m2){ //struct ıse calısmaz bu
}

if(m1==m2){ //record struct ıse calsır
}

 */

//----> Printing Members
/*
 Record struct'lann getirdiği son yeniük ise elemanlarını direkt olarak string!e
TöString fonksiyonuyla çevirdiğimizde bizlere verinin metinsel halini sunmasıdr.
Esasında bu özelliğin record class'larda da olduğunu bilmenizde fayda vardır!
 */


//---> Primary Constructor
/*
 Record struct'lar da positional
records kullanılıyorsa eğer (kullanamsak bıle () yaparsak gene kullanamayız )
constructor tanımlamasına izin
verilmemektedir.

MİKRO SEVİYEDE YAPILAN BİR OPTİMİZASYON NETİCESİNDE RECORD STRUCT'LARIN, NORMAL
STRUCT'LARA ORANLA '20' KAT DAHA FAZLA PERFORMANSLI OLDUĞU GÖZLEMLENMİŞTİR!

 */
#endregion


/*
 Performans cetveli

En performanslı sı en solda 
Record Struct -> Struct -> Record Calss -> Class    

 */
