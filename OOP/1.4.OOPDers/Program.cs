using System;

namespace _1._4.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nesne bır olgunun karsılıgıdır 
            //Nesne sadece  class lardan olusturulabılır 
            //Referans Nedir :Ram in stac bolgesınde tanımlananan ve heap bolgesındekı nesnlerı ısaretleyen referans eden degıskenlerdır .

            MyClass m = null;
            m.a = 12; //calısma zamanında hata (null referans exeptions) verir cunku karsılıgı null 
            new MyClass().a = 12;


            //Object Initializer
            MyClass myClass = new MyClass()
            {
                 a = 12
                 //burada methot kullanılamaz 
            };

            #region Nesne Kopyalama Davranışları | Shallow Copy | Deep Copy

            #region Shallow Copy
            //Var olan bır nesneın degerın referansının kopyalanmasıdır .Shalloww copy netıcesınde eldkı degerı cogaltılmaz sadece bırden fazla referansla ısaretlenmıs olur 
            MyClass myClass3 = null;
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = myClass1;//referans edılmıs ısaretleme yapıldı yenı bır nesne uretılmedı 
            myClass3= myClass2; //referans ettık 

            int a1 = 23;
            ref int b1= ref a1; //buda referans oldugu ıcın Shallow Copy dır

            //Referans turlu degıskenlerın default degerıdır 
            #endregion

            #region Deep Copya
            //burada verı cogalır 
            //deger turlu degıskenlerın default degerıdır
            int a = 12;
            int b = a;//buradakı a nın degerı gelır yanı verı cogaltılır refler ıle bu kopyalama engellenebılır

            MyClass2 m1= new MyClass2();
            MyClass2 m2 = m1.Clone(); //Deep  farklı nesneler
            MyClass2 m3 = m1;  //shallow 

            #endregion

            #endregion

        }

        class MyClass
        {
            public int a { get; set; }
        }
        class MyClass2
        {
            public MyClass2 Clone() 
            {
                return (MyClass2) this.MemberwiseClone();//bır sınıfın ıcerısınde o sınıftan üretilmiş olan o anki nesneyi clonlamamızı saglıyan bır nesnedir object olarak doner
            }
        }
    }
}
