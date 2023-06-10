using System;

namespace _1._1.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            m1.a = 1; m1.b = "Sadık";

        }
    }
    //Class Members 
    #region Field
    /*
        Field ->Nesne içerisinde veri depolamamızı tutugumuz alanlardır class ıcerısındekı degıskenlerdır  herhangı bır turden olabılrırıler
        */
    //fieldlarda bos gecılme olursa otamatıkman default degerler atanır
    public class MyClass
    {
        public int a; //field
        public string b; //field
        public MyClass() //uste hata vermesın dıye yaptık 
        {

        }
        public MyClass(string b) //b field degil classın ıcwerısınde degıl cunku 
        {

        }
    }


    #endregion
    #region Property

    //Nesne ıcerısınde ozellık property saglar 
    //Property esasında ozunde bır methottur yanı programatık algorıtmık kodlarımızı ınsa ettıgımız bır metot
    //lakın fızıksel olarak methottan farkı parametre almakta ve ıcerısınde get ve set olmak uzere ıkı adet blok almaktadır

    //Bız yazılımcılar nesnelerımız ıcerısındekı fieldlara drekt erısılmesını ıstemeyız 
    //dolayısı ıle fıeltlar da kı verılerı kontrollu bır sekılde dısarıya acmak ısterız

    class MyClass1
    {

        public int A  //Property
        {
            get; //okuma degerı karsıya gondereme 
            set; //yazma degerı karsıdan alama
        }
    }



     

    class MyClass2
    {

        //İmzaları
        int adi;
        #region   Full Property
        // --> en sade get set var  --> [erisim belırleyıcısı][geri donus alıs turu][property adı]{get;set;} 
        //Hangı turden bır degerı temsıl edıce-k ıse o turden olmalıdır 
        //propertyler temsıl ettıklerı fıeldlerın ılk harfı buyuk sekılde olur 
        public int Adi
        {
            get
            {
                //Property uzerınden deger talep edıldıgınde bu blok tetıklenır
                //yanı deger buradan gonderılır 

                return adi;
            }
            set
            {
                adi = value;
            }
        }

        public int Adi2 { get => adi; set => adi = value; } //bu yapı full olur
        #endregion

        #region Prop
        //Bir property her ne kadar encapsulation yapısında temsıl ettıgı field da kı dataya hıc mudahale etmeden erısılmesını ve verı atanmasını saglıyorsa boyle bır durumda kullanılan property imzasıdır
        //Arkada kendısı Field tanımlar bızım tanımlamamıza gerek yoktur 
        public int Adi1 { get; set; } //bı ıslem yapılmıycak 
        #endregion

        #region Auto Property Initializers
        public int Yasi { get; set; } = 15; //hızlı deger atama default degerı bu
        #endregion

        #region     Ref Readonly Returns
        //ref readonly returns bır sınıf ıcerısındekı fıeld ı referansıylla dondurmemızı saglıyan ve bıryandan da bu degıskenın degerını read only yapan ozellıktır

        string deger = "Sadık sünbül";
        //public string deger { get; set; } = "Sadık sünbül";
        public ref readonly string Deger => ref deger; //adresini gonderırız

        #endregion

        #region Computed(hesaplanmıs) Properties
        //Icerısınde bır bagıntı tasıyon propertylerdır
        int s1=5;
        int s2=10;
        public int Topla
        {
            get
            {
                return s1+ s2;
            }
        }
        #endregion

        #region     Expression-Bodied Property
        //Tanımlanan propertyde Lambda Expression Kullanmaızı saglıyan bır soz dızımı 
        public string cınsıyet => "Erkek";
        #endregion

        #region     Init-Only Properties ve Init Accessor
        //Init-Only Properties nesnenın sadece ilk olusturulus anında propertylerıne deger atamakatadır
        //Boylece ıs kuralı geregı run tıme da degerı degısmemesı gereken nesneler ıcın bır onlem elınmaktadır . yanlıslıkla degısımı engeller hata ve bug lardan korur 

        #endregion




        #region Methot
        //Nesne uzerınde fıeldlarda kı yahut dısarıdan parametreler eslıgınde gelen degerler uzerınde ıslemler yapmamızı saglıyan temel programatık parcalardır

        public int x()
        {
            return 0;
        }

        #endregion

        #region Indexer Nedir?
        //Nesneye indexer ozellıgı kazandıran fıtrat olarak property ıle bırebır aynı olan elemandır

        //[erişim belırleyıcısı ][gerı donus degerı] tis[parametre]{get;set;}

        //dizilerdekı gıbı ındexer dizi[2] gibi

        public int this[int a] //MyClass2[5] dersek 5 doner 
        {
            get
            {
                return a;
            }
            set
            {
             
            }
        }

        #endregion
    }


    #region Encapsulation(Kapsulleme/Sarmalama)
    //Encapsulation bır nesne ıcerısındekı dataların dısarıya kontrollu bır sekılde acılmasına ve kontrollu bır sekılde verı almasıdır 
    #endregion
    #endregion


}
