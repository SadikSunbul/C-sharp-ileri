
#region Null Conditional Operator - ?.
/*
 Null Conditional operatörü, referanslara
güvenli bir şekilde erişim yapmamızı
sağlayan bir özelliktir.

BU operatör, bir referansla null olup
olmadığını kontrol etmeksizin işlem
yapabilmemizi sağlamaktadır.

Meşhur null referans hatalarını önlemek
için kullanılır.

Null conditıonal operatörü sayesinde
ilgili referans null değilse member
çağrımı gerçekleştirilecektir. Böylece
kodu if — else kirliliğinden kurtarmış
olacağız.
 */
using System.Runtime.CompilerServices;

Person perspn = null;
if (DateTime.Now.Day == 30)
    perspn = new();
if (perspn != null)
    Console.WriteLine(perspn.Name);
Console.WriteLine(perspn?.Name); //bunu yapabilmemiz için person nun null olmaması gerkerı buna emın olmamız gerekıcektır calıstırısak nulexcepsıon hatası verıcektır bunu hata vermemesi için ? operatoru kullanmlaıyız mnormalde ustekı gıbı yazılması gerkeeır her yerde bunu yapmak yerıne ? operatoru bızım ıcın yapar bunu 

//get işlemi için yukarıdakı gıbı yapılabılrı set ıcın daha farklıdır bu 

/*
 BU operdtör, aşağıdaki gibi özellikle
derinlemesine nesne zincirlerini veya
metot çağrılarını işlerken oldukça
faydalıdır! Eğer zincir içerisindeki
herhangi bir değer null ise, operatör null
dönecek ve sonraki çağrıya
geçmeyecektir.
 */
Person person = new Person();

var departman = person?.Branch?.Departman?.DepartmanName;
// burada her kademe kontrol edilir person nullmu personun brancı nul mıdır vb devam eder buradakı ıf else kırlılıgını gıdermıs olduk burada person null ıse branc cagrılmaz zaten 
class Person
{
    public string Name { get; set; }
    public Branch Branch { get; set; }

}
class Branch
{
    public string BranchName { get; set; }
    public Departman Departman { get; set; }
}
class Departman
{
    public string DepartmanName { get; set; }
}

#endregion

#region Null Coalescing Assignment Operatorü - ??=
/*
 NUH Coalescing Assignment operatörü,
bir değişkenin değerini yalnızca null ise
başka bir değerle değiştirmek
istendiğinde kullanılan bir atama
operatörüdür.
 */

Person person1 = null;
person ??= new(); //person null ıse buradakı degerı ver person null olmamıs olsaydı burada yenı nesne uretmıycektı burada 

int? n = 15;
n ??= 3;
//ustekı ornekte n degerı 15 dir cunku n null degıldır n nul olsaydı 3 du degerı

/*
 BU operatör bir değişkenin değerini
kontrol eder, eğer değer null ise sağ
taraftaki ifadeyi ilgili değişkene atar, yok
eğer null değilse mevcut değeri
değiştirmeksizin yoluna devam eder.

Yani anlayacağınız bu operatör, bir
değişkenin var olan değerini korumak
istediğiniz durumlar için faydalı bir işleve
sahiptir.
 */
#endregion

#region Nul(?) Operatoü & Nullable<T>
/*
 NUII(?) operatörü veya Nullable«T» türü,
C#'ta değer türlü değişkenlerin null
alabilmesini sağlayan yapılanmalardır.

C#'ta değer Nürlü değişkenler normal şartlarda
değer yokluğu anlamına gelen null ifadesini
kabul etmezler. Ancak bazı senaryolar gereği,
bir değer türlü değişkenin null olması
gerekebilmektedir. BU gibi durumlar için null(?)
operatörü yahut Nullableq» referansı
kullanılabilir.


 */

int? no1 = null;
Nullable<int> no2 = 3;
//her ıkısıde deger turlu degıskenı nul alabılır hale getırır
/*
 NUII(?) operatörü ile NuIIabIe«T» referansı
arasında işlevsel olarak herhangi bir fark
bulunmamaktadır.
Her ikisi de değer türlerin null değer alabilmesi
için kullanılan farklı syntax'lardır.

Nullable«T» referans') NUll(?)
operatöründen önce kullanılmaktaydı.
Haliyle Null(?) operatörü bu işlem için
daha moderndir ve yaygın olarak
kullanılmaktadır.
 */
#endregion

#region is operatorü
/*
 is operatörü, bir değerin hangi türde
olduğunu kontrol etmemizi sağlayan bir
operatördür.

Bunun yanında bir nesnenin değerlerini
kalıpsal olarakta değerlendirmemizi
sağlayabilmektedir.

Bır nesneyı kalıpsal olarak kontrol etmemızı saglar
 */

//if(person is { Name:"Sadık",Age:>=20,Surname.Lenght:>5})
//{
//    //burada person nun ısmı sadık yası 20 ve buyuk soy ısım uzunluguda 5 den buyuk ıse gir içeriye
//}
Deneme deneme = new()
{
    Name = "Sadık",
    Age = 20,
    Maaried = false
};

//ikiside aynı işlemdir altakı daha kısa ve hız saglar bıze
if(deneme.Name=="Sadık" && deneme.Age>10 &&deneme.Maaried==false)
{

}
//tum propertylerı kontrol etmek zorunda degılız sadece name ve age de olabılır
if (deneme is { Name:"Sadık",Age:>10,Maaried:false})
{

}

//tek  bır deger yanı mesela yası 10 dan buyuk kontrolu ıcın tekıl olarak kullanın yanı
if(deneme.Age>10) //gibi
{

}

class Deneme
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Maaried{ get; set; }
}
#endregion
