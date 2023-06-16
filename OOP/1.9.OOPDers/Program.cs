using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace _1._9.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım Inheritance
            Kadın kadın = new();
           
        }
    }


    #region Inheritance (Kalıtım)
    //oop nın en önemli özellğidir
    //Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir 
    //Aynı aile grubundan gelen nesnelerin ya da yatayda eşit seviyede olan tüm olguların benzer özelliklerini tekrar tekrar herbirinde tanımlamaktansa bir üst sınıfta tanımlanmasını ve her bir sınıfın bu özellikleri üst sınıftan kalıtmsal olarak almasını sağlamaktadır.
    //Böylece hem kod maliyeti düşmekt hem de mimarisel tasarım açısından avantaj saglanmaktadır.

    //kalıtım sınıflara ozgudur
    //bır sınıf sade ve sadece bır sınıftan kalıtım alabilir

    //Recorlar kendi aralarında kalıtım alıp verırler ıstısnaı tek sınıf ıse object sınıfıdır 
    class İnsan
    {
        public int Yaş { get; set; } //kalıtıma gider
        private string İsim { get; set; } //kalıtımda gitmez
        public  string Soyisim { get; set; } 

    }

    class Kadın:İnsan  //Kadın insandan kalıtım alır 
    {
        public bool Makyaj { get; set; }

    }

    #endregion
}
