using System;

namespace _1._8.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region Positional Record Nedir?
    //Norminal Record lar Object Initializer lar ilk degerlerı verılerek uretılebılen readonly dataladır
    //Positional Recordlar ıse esasında recordlar ıcerısınde tanımlama yapabıldıgımız constructor ve deconstructor kullanımlarını daha da özellestırerek kullanılmasını saglamaktadırlar

    //bır record uzerınde ctor ve dector yapılanmasını hızlı bır sekılde olusturmamızı saglıyan bır semantık saglamaktadır 

    //Parametrelerdekı degerlerın propertylerını manuel olrak eklemeye gerek yoktur compıler kendısı bu propertlerı olusturu olusturuken ınıt bı sekılde olusturulur

    //Hem Positional Record hemde kendı ctor kullanmak ıstersek Positional Record u kullnamak zorunlu oldugu ıcın thıs keywordü ile belırtmelıyız
    record myrecor(string isim,string soyisim)
    {
        //public myrecor()  //(string isim,string soyisim) bunlar ctor gorevı gorur bu sadece record a ozeldir 
        //{

        //}

        public myrecor(int a,string isim,string soyisim):this(isim,soyisim)
        {
            
        } //degerlerı gondermezsek hata alrıız 
        public myrecor():this (12,"sad","asfd") //nı ustekını tetıkler
        {
            
        }

        public void Deconstruct()
        {

        }
    }


    #endregion


}
