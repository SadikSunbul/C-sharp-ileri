
#region Anonymous Types Nedir?
/*
 Kodlama süreçlerinde bazen öyle
nesnelere ihtiyacımız olur ki, o nesneyi,
model olarak sade ve sadece o anın
dışında başka bir yerde kullanma ihtiyacı
hissetmeyiz.

Haliyle böyle durumlarda tek bir an için
lazım olan bir nesnenin Class
modellemesini üretmek sizce ne kadar
mantıklı olacaktır?

Düşünürsek eğer, her böyle ihtiyaç
olduğunda bir Class modellemesi
yaparsak eğer bir noktadan sonra
projemizin içeriği tekil kullanımlık
class'lardan oluşan çöpe dönmeyecek
mi?

İşte böyle durumlar için C# programlama
dilinde anonymous type adı verilen
nesneler üretilmiştir. BU nesneler, adı ve
modellemesi tarafımızca yapılmaya gerek
duyulmaksızın pratik bir şekilde o anda
üretilebilen nesnelerdir!

 */

using System.Runtime.CompilerServices;

var anonymousInstence = new
{
    prop1 = "asdasf",
    prop2 = 12,
    prop3 = 'o',
    prop4 = true
};
/*
 Görüldüğü üzere anonymous
type olan bir nesneyi bu şekilde
oluşturabiliyor ve direkt içerisine
opsiyonel bir şekilde property
tanımlamasında bulunabiliyoruz.

Burada tanımlanan
propertyler read-only olarak
oluşturulmakta ve verilen
değerin türüne
bürünmektedirler!

korunaklıdır sadece deger okunur burada deger degısımı olmaz 

 */
/*
 Evet, C#'ta her nesnenin bir türü vardır! Yani
her nesnenin türü belirli bir sınıf modeline
dayanır. Anonymous Type nesneler ise isimsiz
olsalar dahi esasında türsüz nesneler değildir!
BU nesnelerin türlerini bizler değil compiler
belirlemektedir. Ama o anda rastgele
belirlemektedir.

Yani anlayacağınız anonymous
nesneler türsüz nesneler değil, derleyici
tarafından otomatik olarak belirlenen
ve programcının türüne doğrudan
erişemeyeceği türden nesnelerdir!

O yüzden anonymous nesneleri var
keyword'ü ile refere etmek
mecburiyetindeyiz! Çünkü bizler
türünü bilememekte ve doğal
olarak erişememekteyiz.
 */
#endregion
#region Anonymous Types Neden kullanılır?
/*
 Anonymous Typeslar bildigimiz gecıcı verı yapılarıdır tanımlanmasını saglıyan kullanıslı bır ozelliktir . Özellikle LINQ sorguları gibi veri işleme işlemleri sürecinde sonuçları geçici olarak tutmak ve dönüştürmek için biçilmiş kaftanlardır 

Anonymous Typeslar belırlı bır sınıfa ıhtıyac olmadıgı durumlarda veyahut birkaç özelliği geçici olarak taşımamız gerekıyorsa hızlı cozum sunmaktadırlar 
Böylece  verı aktarımı surecınde kolaylastırıcı etkısı vardır 

 */
#endregion
#region Anonymous Types Kullanırken Dıkkat edılmesı gerekenler
/*
 Anonymous Types lar read-only propertylere sahıptır oyuzden eklenen deger degıstırılmıycektır buna dıkkat etkmek gerekır 
 */
#endregion
#region Anonymous Type Olan Nesnelerın falıyet alanları 
/*
 Anonymous Typeslar sadece tanımlandıkları metodun kapsamında kullanılırlar halıyle anlayacagınız tanımlandıkları metodun kapsamın dısına cıkamazlar  

ilgili nesnelerin diğer metotlara parametre vs. olarak tasınması mumkun değildir
YTek bir ŞartİLE?
-->Anonymous Type olarak tanımlanmıs bır nesneyı tanımlandıgı scope un dısına baska hbır yere aktarmak ıstıyor ısek dynamıc turunden işaretlenmelidir
 */

var denemee = new
{
    isim = "SADIK",
    Soyisim = "Sünbül",
    Yaş = 19
};

anonymous(denemee);

void anonymous(dynamic denemee)
{
    Console.WriteLine(denemee.isim);
    Console.WriteLine(denemee.Soyisim);
    Console.WriteLine(denemee.Yaş);
}
#endregion

