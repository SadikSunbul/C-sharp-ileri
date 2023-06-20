using System;

namespace _2._3.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    #region Partial Yapıları İnceleyelim
    /*
     PARTIAL YAPILANMALAR ELERDİR?
Bir class'ın, struct'ın yahut interface'in aynı yahut farklı dosyalarda birden fazla
parçasının tasarlanmasını lakin bu parçaların Özünde bir bütün olarak kullanılmasını
sağlayan, kodun daha organize ve kolay okunabilirliğini arttıran Özelliklerdir.
     */
    class a
    {
        public static void ASD() { }
    }
    partial class X : a
    {

    }
    partial class X
    {

    }
    //compiler bunu tek bır nesne gıbı gorup okur gıze ıslevsellık kazandırır
    //Aynı namespacede olmaları lazım parialların , isimleri aynı olmalıdır

    /*
     PARTIAL YAPILANMALARIN ULLANIM AMAÇLARI
Partial yapılanmaları genellikle aşağıdaki amaçlar doğrultusunda tercih etmekteyiz;
Kod Bölümleme
Büyük ve karmaşık yapadaki sınjflan daha okunabilir ve düzenlenebilir parçalara bölmek için kullanılabilir.

    iş bölümü
Ekiplerin, aynı sınıfın farklı kişırnlarını aynı anda geliştirebilmeleri için kullanılabilir.

    Code Gener,
Code Generator sistemleri tarafından yazdğınjz kodun ezilmemesi için kullanılabilir,
     */

    /*
     PARTIAL YAPILANMALARDA KISITLAMALAR
NELERDİR?
Partial yapılanmalarda aşağıdaki kısıtlama durumları söz konusu olabilir;

    -->Parca olması amaclanan tum yapılar partıal olrak ısaretlenmelıdır 
    -->iç içe partial türler kullanılabilir
    -->Tüm partial yapılar aynı namespace altında bulunmalıdır farklı projeler yahut modullere yayılamaz!
    -->partial olan bır yapının tum parcalarıın turlerı ve ısımlerı aynı olmak zorundadır
     */
    partial class MyClass
    {
        //-->iç içe partial türler kullanılabilir
        partial class MyClass1 //buda olru 
        {

        }
    }
    partial class MyClass
    {
        partial class MyClass1
        {

        }
    }

    //partial olabilen yapılar
    #region Partial record
    partial record record
    {

    }
    partial record record
    {

    }
    #endregion
    #region partial abstract class
    abstract partial class MyClass1
    {

    }
    abstract partial class MyClass1
    {

    }
    #endregion
    #region partial struct 
    partial struct MyClass2
    {
    }
    partial struct MyClass2
    {
    }
    #endregion
    #region partial interface
    partial interface IInterface
    {

    }
    partial interface IInterface
    {

    }
    #endregion
    #endregion
    #region Partial Methotlar
    //partial yapılar partıal methotlar barındırabılırler
    //Partial metotlar ne ıse yarar kı? ->Partial metotlar sınıfın bır parcasında gelıstırıcının metot bıldırımınde bulunmasını saglar baska bır parcasında ise diğer geliştirici tarafından bu metot tanımlanabilir bunun yararlı oldugu ıkı senaryo vardır 

    #region Template Code
    //Geliştiirlen kodda metotlara dair bir şablon olusturmak ıcın kullanılabılr
    //bu sablonların uygulanıp uygulanmıyacagına dair gelistiricinin karar vermesine olanak tanır
    //Eğer şalonu tanımlanan meto uygulanmazsa derleyici tarafından metodun imzası ve o metotda dair yapılan tüm çağrılar tetıklemeler kaldırılır

    partial class MyClass4
    {
        public MyClass4()
        {
            x();
            y();
            z();
            /*
             x ve z acılmamıs olsa hata vermez sankı yokmus gıbı devam eder y acık oldugu ıcın onu calıstırır burada ama x ve z tyokmus gıbı davranır acarsak bunlarda calısıcaktır
             */
        }
        partial void x();
        //tanım
        partial void y(); //bunu yazmadan alttakini olusturamazsın 
        partial void z();

        //govde
        partial void y()
        {
            throw new NotImplementedException();
        }
    }
    partial class MyClass4
    {
        //y cagırıldıgı ıcın uste burada cagrıalamaz
        partial void x()
        {
            throw new NotImplementedException();
        }
        partial void z()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region Source Generator
    //Source generator sıstemlerı ıle sınıflarda tanımlanmıs olan partial metot imzalarına karsılık govdeler olusturulabılır
    //Geliştirici uygulanacak metodun partial bir şekilde şablonunu ekledikten sonra source generatorderleme sırasında bu metodun uygulanmasını saglar
    //Tabiki geliştirici isterse bu metotların govdelerı source generator tarafından uretılemden once ya da bir baska deyısle bu metotlar uygulanmadan once baska bır noktadan cagrılabılırler tetıklenebılırler.


    #endregion
    #region PARTIAL METOT KURALLARI

    //partial metotların run tımeda var olucagı kesın degıldır eger ımplementatıon edılmedilerse partial metotlar derleme sırasında yok sayılırlar
    //yukarıdakı durumdan dolayı partıal metotlar delegateler ıle temsıl edılemezler

    //Partıal metotlar ancak partıal claslar ıcerısınde kullanılmalıdır gerı donuslerı void olması zorunludur statıc veya generic olabılırler out parametresı almazlar lakın ref alabılırler extren ve virtul olmazlar 

    //govdeler publıc yapılıp dısarıdan erısılebılrı

    
    #endregion
    #endregion
}
