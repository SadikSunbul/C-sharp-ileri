using MyNamespace;
using System.Runtime.CompilerServices;
using static MyNamespace.MyClass8;
#region NameSpace
//Kod organızasyonunu saglamak ıcın kullanılan bır yapılanma 
//kodsal acıdan ınterface struct class vb yapıları duzenlı ve tertıblı bır ınsa gerceklestırebılmektedir
//davranıssal olraka benzer olanları aynı namespace ıcıne konulur catalın yanına tabak konulmaz onun gıbı dusun 


#endregion

#region Namespce nerede ve nasıl tanımlanır?
//namespace keyvordunden yararlanılır
//alttakı gıbı kullanılır
//bunun ıcerısıne for konulmaz buraya yapılar konulur yanı class ınterface vb seyler int strıng for vb seyler klasların ıcerısıne konulur


namespace MyNamespace
{
    //bunlar yapı 
    class MyClass
    {

    }
    struct MyStruct { }
    interface IInterface
    {

    }
    abstract class MyClass1
    {

    }
    namespace MyNamespace1
    {

    }
}

namespace MyNamespace2
{
    namespace MyNamespace2
    {

    }
}

//Namespace lerın ısımlerı aynı olabilir
//C# dosyasında yanı cs dosyalrında ve namespacelerde tanımlanabılır class ıcınde vb yerlerde namespcae olamaz
#endregion

#region Fıle Scoped NameSpace Declaratıon
//Namespaceyı dosya bazlı namespace ekleme namespace Ahmet; dedıgımızde Class1 de dosya bazlı olur bunun avantajı {} lerı arındırrız malıyet kazancı saglar

// Ahmet.MyClass(); deyınce gelrı


//Fıle Scoped NameSpace kullanılamn yerede normal name spce tanımlanamaz
#endregion

#region namespacelerin Dağtık Tanımlanması
//Namespacelerın uygulama bazlı dağıtık bir şekilde de kullanabilmekteyiz şöyleki;

//aynı dosya yada farklı dosyalrada aynı ısımde namespce tanımlana bılır 

//farklı dosyalarda aynı namespce ısmı verılebılır partıal class gıbı dusun compıler edılırken aynı yerde toplanıcatır aynı ısımdekıler

//Yanı anlıyacagımız farklı dosyalarda konumlarda dızınlerde tanımlanmıs aynı "derecedeki" namespaceler compıler acısından bır urun olarak degerlendırılmektedır 

namespace MyNamespace
{
    class MyClass7
    {

    }
}

namespace MyNamespace
{
    //Tanımlanamaz zaten aynısı var ondan yazılırsa hata alınır
    //class MyClass7
    //{

    //}
    namespace MyNamespace2 //farklı bır seviyedir burası
    {
        //Burada tanımlana bılır 
        class MyClass7
        {

        }
    }
}

#endregion

#region namespace ıcerısınde ne tanımlanır
/*
 class
Record
Struct
AbstractClass
Interface
Delegate
Enum
NestedNamespace
Record Struct
 */
#endregion

#region Erısım 
//namespcenın  adını . dedıkten sonra ıcerısınde gelir
//bu herseferınde yazmak yerıne en uste usıng ıle eklıyebılırız

#endregion

#region Usıng Dırectıf & Statik using
//using MyNamespace; veya using m=MyNamespace; olarak kullanılabiliriz m deyıncede gelıcektır alliesler genelde cakısmaları engellemek ıcın kullanırız

//statık : using static MyNamespace.MyClass8; statık kısmlara boyle ulasabiliriz
namespace MyNamespace
{
    class MyClass8
    {
        static class MyClass
        {

        }
    }
}

#endregion


#region Global Operatörü

/*
 Kimi namespaceler vardırkı uygulamnın hemen hemen her yerınde sık sık kullanıldıkları ıcın usıng bıldırmek durumunda kalınmaktadır
Bızler bu namespace lerın her ıhtıyac dogrultusunda usıng ıle bıldırmekten ıse global
keywordu eslıgınde tek seferlık uygulama sevıyesınde tanımlama sansına sahıbız

bunun ıcın 2 farklı yaklasım seergilieyebliriz:

.csproj dosyasına gıderek ekleme yapabılrıız bu bıraz karısık 

2.yontem ıse herhagıbır dosyada (cs) global usıng namespca bu daha kolaydır 
 */

#endregion

#region :: operatörü
//Pek kullanılmaz global haricinde 

//C# da :: operatoru kullanıma baglı olarak ıkı farklı sekılde davranıs sergıleyebılmektedır

//1->ilk olarak uygulamadaki namespacelere global keyordu uzerınden erısım gosterebılmemıze olanak vermektedir
//global::MyClass m1=new(); globaldakı tum yapılnmalara drekt erısım gosterılır

//2-> alyas içindeki lere ulasmak ıcınde kullanılır using m1=Mynamespcae; m1::Myclass() gibi

#endregion