using System;

namespace _1._0.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınıf Nedir? Neden sınıf yapısı kullanılır
            //oop de bır object olusturabılmek ıcın oncelıkle o objenın modellenmesı tanımlanması gerekmetedır
            //bir objecnın modelını tanımını olusturabılmek ıcın class yapısı kullanılır 

            #endregion
            #region Sınıf ıle Nesne arasındakı ilişki Nedir?
            //class larda nesnelerdekı ortak alan tanımları yapılır isim,soyisim ... hepsınde ısım var ama degerler farklı olabılır 


            #endregion
            #region sınıf Nasıl ve nerde olustururlur 
            // class [ism]{ } tanımlanır claslar bır referans turdur 
            //sınıf 3 farklı yerde olusturulur
            /*
                Namespace içerisinde
                Namespace dısında
                class içerisinde(Nested Type [içiçe kılaslar])
             */

            //bır class tanımlamasında tanımlanana yerde aynı ısımde brıden fazla class tanımlanamaz!
            #endregion
            #region sınıf ıle nesne modeli tasarlama



            #endregion
            #region sınıf modelınden referans noktası olusturma 
            // OrnekModel bu bır turdur bunu kullanıcaz
            OrnekModel model = new OrnekModel() { a=10/*,b=20 */};
            model.x();  //degerlerı kendı elemanlarından alır bos gecersen default degerını alır 
            int deger = model.y();
            Console.WriteLine(deger);
            #endregion
        }
    }
    class OrnekModel //sınıf ıle nesne modeli tasarlama
    {
        //field -->class ıcınde degıskenler fıeld dır 
        public int a;
        public int b;

        //function 
        public void x()
        {
            Console.WriteLine(a+" "+b);
        }

        public int y()
        {
            return a * b;
        }

        //
    }

    public class MyClass
    {

        class MyClass3 //iç içe class
        {

        }
    }
}
 //buradada olusturulur 
class MyClass2
{

}
