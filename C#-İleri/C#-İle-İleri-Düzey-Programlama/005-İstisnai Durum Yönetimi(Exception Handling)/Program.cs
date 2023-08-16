
#region İstisnai Durum Yönetimi(Exception Handling)

// İstisnai Durum Nedir?
/*
 İstisnai durumlar, bir programın çalışma sırasında
normal akışını bozan, beklenmeyen olay veya
durumları ifade eder.

İstisnai durumlar, genellikle programın doğru
çalışmasını engelleyen veya istenmeyen sonuçlar
doğuran hatalı durumlar olarak düşünülebilir.

Misal olarak; bellek yetersizliği, hatalı girdiler,
sıfıra bölme yahut ağ kopması veya hatası gibi
durumlar istisnai durumları yaratabilecek örnek
senaryolar olabilir.

Bizler istisnai durumlar adı altında ifade edilen
tanımlarısınıflar/çalışmalar sayesinde, programın
akışını olumsuz etkileyen anlarda, normalden farklı
bir şekilde yönlendirmede bulunabilir, kullanıcıya
uygun bir hata mesajı gösterebilir yahut hatayı
düzgün bir şekilde işleyebiliriz..

Böylece programın çökmesini veya istenmeyen
sonuçlar doğurmasını engelleyebiliriz.

C#'ta istisnai durumlar, bir dizi sınıf tarafından ele
alınmaktadır ve her hatayı tarif edecek(karşlık
gelecek) bir sınıf tanımı söz konUSUdUi. Hata
durumlarında, bu hataların işlenmesi için dilin getirisi
olan try-catch yapısı kullanılarak bu sınıflardan
istifade edilmektedir.

İstisnai durumların doğru bir şekilde yönetilmesi,
programın daha güvenilir ve hata toleransına
sahip olmasını sağlayacaktır!
 */

// İstisnai Durumlar Neden Gereklidir?
/*
 İstisnai durumları bir programın karşılaşabileceği beklenmgyen veya hatalı durumları ele almak ve hatanın getirisi olan problemleri kendimizce
manipüle etmek için gereklidir. Şimdi istisnai durumlarının bazı gereklilik nedenleri sıralayalım;

Hata İşleme ve Kurtarma => 
    Programlar, olası hataların meydana gelme ihtimali olan birçok karmaşık
    işlemi içeren yapılanmalardır! İstisnai durumlar; bu hatalann program
    tarafından tanımlanmasını, yakalanmasını ve uygun şekilde işlenmesini
    sağlarlar. Bu sayede programcılar hataları daha rahat handle edebilirler ve
    kullanıcılara daha anlamlı bir şekilde sunabilirler.

Program Kararlılığı =>
    İstisnai durumlar; bir programınçökmesini ve çalışma zamanında karmaşık
    hatalar vermesini engeller. Eğer ki, yazılımda istisnai durumlar hesaba katılıp
    gerekli çalışmalar yapılmazsa, programın akışı normalden sapabilir ve
    istenmeyen sonuçlar doğabilir ve bu sonuçlar son kullanıcılara yansıtılabilir.
    Halbuki istisnai durumlar doğru bir şekilde yönetilirse bu programın
    kararlılığına yansıyacaktır.

Hataların İzlenmesi ve Analizi =>
    İstisnai durumlar, programın çalışması sırasında meydana gelen hataların
    izlenmesini ve analiz edilmesini sağlarlar. Özellikle log mekanizmaları bu
    istisnai durumlarından oldukça beslenerek metrik oluştururlar. BU,
    geliştiricilerin hangi hataların ne zaman ve nerede meydana geldiğini daha
    iyi pnlamalarına yardımcı olur ve böylece sorunların giderilmesi daha etkili bir
    şekilde gerçekleştirilebilir.

Kullanıcı Deneyimi =>
    İstisnai durumların düzgün bir şekilde yönetilmesi, kullanıcı deneyimini
    olumlu yönde etkiler. Kullanıcıya anlamlı hata mesajları sunarak, kullanıcının
    duruma dair ne olduğunu anlamasına ve gerektiğinde yardım almasına ve ne
    yapması gerektiğine dair yönlendirici bilgi verilmesine olanak tanır.X

Güvenlik =>
    İstisnai durumları programın beklenmeyen girdilere veya durumlara karşın
    nasıl tepki vereceğini tanımlayan yapılanmalardır. BU sayede kötü niyetli
    kullanıcılar tarafından yapılan saldırılara karşı koruma sağlanabilir.

Hata izleme ve Kayıt =>
    İstisnai durumlar, hataların kaydedilmesi ve izlenmesi için bir fırsat
    sunmaktadırlar. BU kayıtlar, programın sahadaki performansını ve
    sorunlarım takip etmek için kullanılabilir. -

 */

//Peki istisnai Durum 'Yönetimi' Nedir ?

/*
 İstisnai durum yönetimi (Exception Hgndling), bir
programın çalışması sırasında meydana
gelebilecek hataları ya da beklenmeyen olayları
yani istisnai durumları; yakalama, işleme ve bu
durumlarla başa çıkma sürecidir.

stisnai durum. önetimi, programcılara hataları
tahmin edebilir bir şekilde ele alabilme yeteneği
sağlar. BU süreç, programın çökmesini engeller,
hataların kullanıcıya daha anlamlı bir şekilde
sunulmasını sağlar ve programın genel
kararlılığını artırır.
 */

#endregion

#region İstisnai sınıflar nelerdir?
/*
 C#'ta, bir dizi önceden tanımlanmış istisnai durum sınıfı mevcuttur. BU sınıflar, farklı türde hataları temsil eder ve bu hataların işlenmesi için gerekli
araçları sunar.

Exception              => Tüm istisnai durum sınıflarının temel sınıfıdır.

ArgumentException      => Metotlara geçirilena rgümanların hatalı oldUğU durumları temsil eder.

ArgumentNuIIException  => Bir metoda nı.JIl bir argüman geçildiğinde fırlatılır.

NuIlReferenceException => Bir nesnenin null referansı üzerinden işlem yapılmaya çalışıldığında fırlatılır.

DivideByZeroException  => Bir sayının sıfıra bölünmesi durumunda fırlatılır.

TimeoutException       => Bir işleme ayrılan süre sona erdiğinde fırlatılır.

NotSupportedException  => Bir metot yahut operasyon desteklenmediğinde fırlatılır.
 */
#endregion

#region özel İstisnai (Exception) Sınıf Nasıl Oluşturulur?
/*
 C#'ta, hazır gelen istisnai sınıfların dışında,
kendimize özel exception sınıfları oluşturabilir ve
program sürecindeki belirli hataları daha anlamlı
ve spesifik bir şekilde temsil edebiliriz.

Özel istisnai sınıf tasarlayabilmek için aşağıdaki
kurallarda hareket edilmesi gerekmektedir;
 */

using System.Data.SqlTypes;
using System.Security.Cryptography;
/*
 Bir sınıfın ekception sınıf olabilmesi için
'Exception' sınıfından ya da onun alt
sınıflarından türetilmesi gerekmektedir.
 */

try
{
    int i = 0; int j = 1;
    int a = j / i;
}
catch (Exception ex)
{
    throw new CustomExcepsion();
}
class CustomExcepsion : Exception
{
    public int Deneme { get; set; }
    public CustomExcepsion()
    {

    }
    public CustomExcepsion(string? message) : base(message)
    {

    }
    /*
     İstisnai sınıflarda genellikle constructor
    üzerinden gerekli bilgiler alınarak
    özelleştirmeler yapılmakta ya da istenirse
    opsiyonel olarak ilave özellikler
    eklenmektedir.
     */
}
#endregion

#region throw Keyword'ü ile Hata Fırlatma
/*
 throw keyword'ü, C# programlama dilinde
istisnai durum sınıflarını fırlatmak için kullanılan
bir keywörd'dür.

keywordl programın çalışması sırasında, belirli
bir urumda, programcının istediği istisnai durum
sınıfını fırlatmasını sağlar.

Böylece, istisnai durumlar programın akışını
istenildiği şekilde yönlendirmek veya daha
spesifik hata mesajları sunmak için
kullanılmaktadır.

 */

#endregion