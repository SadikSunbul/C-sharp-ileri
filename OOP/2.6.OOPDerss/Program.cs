using System;

namespace _2._6.OOPDerss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İnterfaceler
            MyClass5 my = new MyClass5();

            Ia ıa = my;

            Ib ıb = my;

            Ic ıc = my;

            denemea denemea = new();

            Iz ız = denemea;
            ız.y();
        }
    }

    #region İnterface
    // Interface nedir ? 
    // Programlama sureclerınde interface yapılnaması nesnelere dırekt olarak bır arayuz sablon olusturulmasını ve bu arayuz uzerınden gelıstırıcı ıle nesne arsındakı etkılesımı daha da kolaylastırılmasını saglayan aractır

    //sadece gelıstırıcı ıle etkılesımını kolaylastırmakmakta ayrıca bır programın farklı bır proograma yahut bılesenle etkılesımını de kolaylastırmaktadır

    //interfacelerin nesneye bır ara yuz saglaması, kullanıcı acısından ilgili nesnenin nasıl calıstıgına daır ayrıntılı bılgıye ıhtıyac duyulmaksızsın sadece arayuzun sundugu fonksıyonşarı veya propertyleri kullanarak etkılesıme gırmesını saglar

    //Yani anlıyacagımız interface o nesneye bır abstractıon uygulayarak belırlenmız bır arayuz uzerınden  calısılmasını be boylece ılgılı nesne ıle gelıstırme surecının kolaylastırılmasını saglamaktadır 

    //Interface abstractclass ın sadece ımzalara konsantre olmus halıdır o yuzden abstractıon davranısı acısından abstract class a nazaran daha elverişlidir



    #region Can - Do (yapabilir) ilişkisi
    //interface bır sınıfa ıcerısınde tanımlanacak member ların kendi içerisindeki ımzaların olacagının tahutunu vermektedir
    //İşte bizler bu tahütdden interfacelerin can - do ilişkisi davranısı sergıledıgı gozlemlemekteyız 
    interface Imy
    {
        void A();
        void B();
    }

    class deneme : Imy
    {
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Interfacelerıi neden kullanırız 
    //farklı nesneler veya bılesneler arsında iletişimi kolaylaştırmak  bir standarta tabi kılmak birbiriyle uyumlu hale getirmek için

    // class A ---> Interface <---calss B

    //Sistemin ve mimarinin moduler bır sekılde tasarlanabılmesı için 
    /*
     class[
    A --> I1ınter den gelir
    B --> I1ınter
    C --> I1ınter
    D --> I2ınter
    ]
     */

    //Farklı geliştiricilerin ve ekiplerin söz konusu oldugu calısmalarda belırlenmıs bır arayuz uzerınden sınıfların tarsarlanmasını saglıyarak dokumantasyon gerektırmeksızın programatık kurallar koyabılmek için

    //Kullanılır 

    #endregion

    #region İnterfaceler
    //İnterfaceler referans tülü değişkenlerdir yani bir referanstırlar -->IMyInterface ınterface1=...;
    //İnterfaceler nerelerde tanımlanır ? 
    //Bır class nerede tanımlana bılıyor ıse orada tanımlanabılır ler herhangıbı bır  name space, class struct yahut ınterface içerisinde interface tanımlanabılır ya da ıstersenız namespace dısında tanımlama yapabılırsınız

    //Methot ıcerısınde class ınterface struct record gıbı seyler tanımlanmaz cunku methot ıcerısınde operasyonel surecler yurutulur 

    interface IMyInterface
    {

    }

    #region İnterface imazaların oluşturulması
    //Methot ve property ızmazları tanımlanabılıur
    //Imza tanmlama surecınde Access Modifer eşliğinde metot ve propertylerın govdeleri tanımlanmaz sadece imzaları tanımlanır

    //İnterface ıcerısınde field tanımı olmaz çünkü : fieldların metotlar ve propertyler tarafından operatif olarak kullanılmalıdır Halıyle metotların yahut propertylerın kullanıcakları operatıf defgıskenlerı tanımlamak ıhtıyac surecının parcası olacagı ıcın ınterface ıcerısınde tanımlanmaları gereksız sacma olacaktır Bu yuzden fıeld tanımı yasaklanmıstır

    //
    interface IExample
    {
        void AMethot();
        int BMethot();
        int CProperty { get; set; }

    }

    interface IMyInterface2
    {
        void x();
        void y(int a);
        int z { get; set; }
    }

    abstract class MyClass
    {
        public abstract void x();
        public abstract void y(int a);
        public abstract int z { get; set; }

        public bool D()
        {
            return false;
        }
    }

    #endregion



    #endregion

    //İnterfaceler sınıfların imzalarıdır

    #region İnterface Implementation Yöntemleri 
    //alt enter yap ımplament et 
    class MyClass1 : IMyInterface2
    {
        public int z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void x()
        {
            throw new NotImplementedException();
        }

        public void y(int a)
        {
            throw new NotImplementedException();
        }
    }

    //Tum uyelerı acık uygula dedıgımızde farklı gelıcek burası ılerıkı dersın konusu orada detaylıca ıslenıcek
    class MyClass2 : IMyInterface2
    {
        int IMyInterface2.z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IMyInterface2.x()
        {
            throw new NotImplementedException();
        }

        void IMyInterface2.y(int a)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region İnterfaceler de coklu kalıtım durumu
    interface Ia
    {
        void A();
    }
    interface Ib
    {
        void B();
    }
    interface Ic
    {
        void C();
    }
    class MyClass5 : Ia, Ib, Ic //hepsı ıplament edildi
    {
        //Myclass5 i larılıya bılenler Ia Ib Ic 
        /*
        Myclass5 ımplament=Myclass5 new();
        Ia ımplament=Myclass5 new();
        Ib ımplament=Myclass5 new();
        Ic ımplament=Myclass5 new();
        bunların hepsı calısıcaktır
         */
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }

        public void C()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region İnterfacenın İnterfaceden türemesi
    //bır interface bırden fazla interfaceden türiyebilir

    interface Ix
    {
        void x();
    }
    interface Iy:Ix
    {
        void y();
    }
    interface Iz:Iy,Iq //buradakı kalıtım farklıdır class ların kalıtımına benzemez 
    {
        void z();
    }

    interface Iq
    {
        void q();
    }

    class denemea : Iz
    {
        public void q()
        {
            throw new NotImplementedException();
        }

        public void x()
        {
            throw new NotImplementedException();
        }

        public void y()
        {
            throw new NotImplementedException();
        }

        public void z()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Bir class ınherıtance ıle bırlıkte ıplamentation nasıl yapılır
    //yanı bır sınıf hem bır sınıfatan turıycek hemde ınterface ımplament edıcek 

    // ılk once classtan kalıtım almalı sonradan interfaceden implament alınmalıdır

    //C# da bır sınıf hem bır calss dan hemde (aynı anda) abstract calss tan turiyemez hata alırız ama istediğimiz kadar interfaceden turıye bılrıler 
    interface Ide
    {
        void x();
    }
    interface Iye
    {
        void y();
    }
    class deneem1
    {
        void deneme()
        {
            throw new NotImplementedException();
        }
    }
    class deneme2 : deneem1, Ide, Iye
    {
        public void x()
        {
            throw new NotImplementedException();
        }

        public void y()
        {
            throw new NotImplementedException();
        }
    }

    #endregion
    #endregion
}

