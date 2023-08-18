


#region Enumeration nedir? Neden kullanılır
/*
 Enunmeration belirli sayısal değerleri sabitleştirilmiş metinsel
karsılıklıklarıyla temsıl etmek ıcın kullanılan bır verı turudur

Bılıyorsunuz kı bızler kodlama surecınde belırlı durumarı sayısal 
olarak ıfade ederıs Mısal oalarak cınsıyet bılgısı yahut evlılık durumu 
gıbı ıkılı verılerı genelde 0 veya 1 olarak ıslerız 

Ya da bır sıparısın durumunu ıfade eden verılerı de;0(beklıyor),
1(işliyor),2(spariş başarılı),3(iptal edildi) seklinde sayısal 
kabuller uzerınden yonetiriz

işte bu yaklasım netıceesınde kod ıccerısınde ıs mantıklarını sayısal
verıler userınden yonetmek oldukça zor ve karmasık olabılmektedır

kodun okun bılırlıgını ve anlasırlıgını artıtrı ve bakımı kolaylaştırır

 */
/*
 Ana Amaçları

---> Anlaşılabilirlik ve Okunabilirlik
Geliştiriciler için kodun içerisinde sabit
sayısal değerler kullanmaktan ziyade,
bu değerlere karşılık anlamlı isimler
kodun daha anlaşılır ve okunabilir
olmasını sağlayacaktır. Misal olarak;
Pazartesi için 1 değeri yerine
DayOfWeek.Monday ifadesini kullanmak
daha açıklayıcıdır.

---> Değerleri Gruplama
Enumeration'lar; cinsiyet gibi, sipariş
durumları gibi, haftanın günleri ya da
kullanıcı türü gibi değerleri mantıklı bir
şekilde gruplamak için de
kullanılmaktadırlar. Nihayetinde kodun
içerisinde kanşık sayısal değerlerden
ziyade, anlamlı ve kodun mantığını
yansıtan tanımlar üzerinden çalışma
sağlarlar.

---> Hata Riskini Azaltma
Enumeration'lar, değerlerin belirli bir
kümeden seçildiğini garanti ederler. BU,
yanlış değerlerin veya değerlerin dışında
kalan durumların kullanımını önlemekte
ve hata riskini azaltmaktadır.

---> Uygulama ve Bakım Kolaylığı
Enumeration'lar, kodunuzun daha
düzenli olmasını ve bakımının daha
kolay hale gelmesini sağlarlar.
Değerlerin değiştirilmesi veya eklentiler
yapılması gerektiğinde enumeration'lan
güncellemek oldukça kolaydır.


 */

#endregion

#region Enumeration nasıl tanımlanır ve kullanılır
/*
Burada enumeration elemanlarının sırası ıle 0 dan baslar ardısık bır sekılde otomatık olarak compller tarafından numaralandırıldıgını belırtmemız sımdılık yeterdır

enum OrderStatus
{
    Completed, //0
    Failed,   //1
    Suspend  //2
}
kullanımı:
OrderStatus statu=OrderStatus.Completed;
string statu=OrderStatus.Completed.ToString();

Console.WriteLine(OrderStatus.Completed);  // cıktısı -> Completed olur

 */
//MANUEL SAYISAL DEGER EKLEME
/*
enum OrderStatus
{
    Completed = 3,  //3 
    Failed,     //4
    Suspend   //5
}
//olur 

enum OrderStatuss
{
    Completed = 3,  //3 
    Failed = 12,     //12
    Suspend   //13
}

enum OrderStatusss
{
    Completed,  //0 
    Failed,     //1
    Suspend = 13   //13
}
*/
#region Enumerationlara erısım yontemleri
/*
 1-> OrderStatus statu=OrderStatus.Completed;
 
2->
    string order="Completed";
    OrderStatus status=(OrderStatus)Enum.Parse(typof(OrderStatus),order); //var ıse ordera dondur ver 
    burada OrderStatus ıcerısınde order ı ara var ıse onun statusunu dodnur 
 
3->
    OrderStatus status0=(OrderStatus)0; //burada Completed gelır
    cw((int)Completed.Failed); //2

4-> var type=Enum.GetValues(typeof(OrderStatus));//tum elemanları elede edebılırız
    foreach (var typ in type)
    {
        Console.WriteLine(typ);
    }
    //cıktı 
            Completed 
            Failed     
            Suspend

 */


#endregion
#endregion

#region Metınsel temsıller
/*
 Enumeration elemanlarına metınsel temsıller eklemek enum degerinin daha kullanıslı hale gelmesını saglar

Metınsel temsiller enum degerlerını kullanıcı arayuzlerınde goruntulenme gıbı durumlarda oldukca kullanıslıdır 

Bır enumeratıon ıcerısındekı elemanlara metınsel temsıl etmek asagıdcakı yontem uygulanmaktadır
 */
/*
using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;

OerderStatus status = OerderStatus.Completed;

var descırıptıon = status.GetType()
    .GetField(status.ToString())?
    .GetCustomAttribute<DescriptionAttribute>()?
    .Description; //"Sipariş başarılı" yazar


//hepsını lısteleme 

status.GetType()
    .GetFields()
    .Select(f =>
    {
        var descrıptonAttrıbute = f.GetCustomAttribute<DescriptionAttribute>();
        return descrıptonAttrıbute?.Description;
    })
    .Where(d => d != null)
    .ToList()
    .ForEach(i => Console.WriteLine(i));


enum OerderStatus
{
    [Description("Sipariş başarılı")]
    Completed, //bunlar bır field olarak tanımlanmıs 
    [Description("Sipariş başarısız")]
    Failed,
    [Description("Sipariş Askıda")]
    Suspend
}
*/
/*
-----> Enumeration
        Enumerationlar, semantik anlamı olan
        değerleri belirtmek için kullanıldığı için kodun
        daha anlaşılabilir ve okunabilir olmasını
        sağlarlar.

        Enumeration'lar, belirli bir değer kümesini
        temsil etmek için kullanılırlar. Değerler sınırlıdır
        ve dışandan gelen geçersiz değerlerin
        kullanımını engellemeye yardımcı olurlar.

        Enumeration'lar, hataların önlenmesine
        yardımcı olabilirler, çünkü yalnızca belirli bir
        değer kümesini kabul ederler.

        Enumeration'lar, kodun daha düzenli ve
        bakımının daha kolay hale gelmesini
        sağlarlar. Yeni değerlerin(elemanlann)
        eklenmesi ya da var olanların düzeltilmesi
        hem kolaydır hem de kodun genel yapısını

-----> Constant String
        Sabit string'ler ise doğrudan anlaşılamayabilir
        ve yanıltıcı olabilirler. Hele hele aynı string'in
        farklı yerlerde farklı anlamlara gelmesi olasıdır.

        Herhangi bir string'i sabit olarak
        kullanabilirsiniz, ancak bu, değerlerin
        denetlenmesini zorlaştırabilir.

        ------------------


        Sabit string'lerin değiştirilmesi veya
        düzenlenmesi gerektiği durumlarda birçok
        noktada bu değişikliği koordine etmek
        gerekebilir.
 */
#endregion

#region Avantaj lar
/*
 •
Rol ve Avantajları

Anlaşılabilirlik ve Bakım Kolaylığı
Enumeration'lar, kodun daha anlaşılır ve düzenli
olmasını sağlarlar. Değerleri semantik anlamlara sahip
olduğu için, kodun okunabilirliğini artınr ve bakım
işlemlerini daha kolay hale getirir.

Kod Kusurlannı Azaltma
Enumeration'lar, geçerli değer kümesini belirlemek için
kullanıldığından, kodun hatalı veya geçersiz değerlerle
çalışmasını engeller.

Değer Değişiklikleri Yönetimi
Eğer değerlerde değişiklik yapmanız gerekirse,
enumeration'lan güncellemek oldukça kolaydır. BU,
değerlerin birden çok yerde düzeltilmesi ihtiyacını
azaltır.

Daha iyi Dokümantasyon
Enumeration kullanılan kodun dokümante edilmesi,
karmaşık değerlerin kullanıldığı kodlara nazaran daha
kolay ve izah edilebilirdir.


•
Sınırlamalar ve Dikkat Edilmesi Gerekenler

Geniş Enumeration'lar
Büyük enumeration değerleri bellek kullanımını
artıracağından ve işlevleri yavaşlatacağından
performans sorunlanna yol açabilir. O yüzden
enumeration'lar sınırlı bir veri kümesini temsil etmek için
kullanılmalı, haddinden fazla büyük verilerde tercih
edilmemelidir.

Arayüz ve Soyut Sınıflarla Entegre Olamama
Enumeration'lar, arayüzleri veya abstract class'lon
implemente edemezler. BU durum, bazı tasanm
desenlerini veya uygulama yapılannı kullanırken
kısıtlamalara yol açabilir.
Sabit Değer Kümesi

Enumeration'lar, tanımlandıktan sonra dinamik olarak
değerlerinin değiştirilmesine izin vermezler. BU tarz
dinamik değişikliklerin olacağı senaryolarda
enumeration' lardan ziyade veritabanı yapılarından
istifade etmeniz daha elverişli olabilir.
 */

#endregion

#region Falgs Atrubutu nedir nasıl kullanılır?
/*
 Bazen bir özelliği tanımlarken bu tanımlamayı bir enumeration içerisindeki birden fazla elemanla gerceklestırmemız iş icabı gerekebilmektedir
Misal olarak yetkılerı ıfade eden enumeratıon dan deger verırken bırden fazla deger verme durumu soz konuusu oalbılır

 */
Console.WriteLine(Permissions.Add | Permissions.Remove | Permissions.Update); //burada toplama işlemi yapılır ve soyleki 0+1+2 =3  Olucagından dolayı 3 dekı degerımız List dir yanı o gelicek buraya 

Console.WriteLine(Permissions.Add | Permissions.Remove | Permissions.Update);//herhangıbır degere karsılık gelememsını saglıyalım buranın toplamı artık 7 oalrak gelıcektır bunu bıze 7 verme bıze metınsel oalrak ver onun ıcın [Flags] yazmak yeterlidir burada artık Add,Remove,Update yı verıcektır artık 

[Flags]
enum Permissions
{ //burada 2 ussu n ıle yaparsak hangısını toplarsak toplıyalım baska bır elemana karsılıık gelemz artık 
    Add=1,
    Remove=2,
    Update=4,
    List=8
}

/*
 Görüldüğü üzere enumeratıon eleman cağırımları arasında | operatoru ile basit düzeyde bir birleştirme yapılmaktadır 

Bu birleştirme neticesinde sağlıklı netice elde edebilmek için enumerationların elemanlarına toplamları farklı olabilecek değerler vermemiz gerekecektir Bunun için 2 ussu n formulu gayet yeterlidir

 */
#endregion