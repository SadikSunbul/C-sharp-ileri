using System;

namespace _1._5.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #region Encapsulation
    //Nesnelerımızdekı fieldlarını kontrollu bır sekılde dısarıya acılmasıdır 
    //nesnelerımızı basklarının yanlıs kullanımlardan korumak ıcın kontrolsuz degısıme kapatmaktır 
    //Encapsulation 2 turlu uygulanabılır 1 methot 2 property ıle en yaygını 2. olan dır 


    class MyClass
    {
        //eskıden encapsulatıon 
        private int a;
        public int AGet() //okuma ıslemı 
        {
            return this.a;
        }

        public void ASet(int value) //deger yazma 
        {
            this.a = value;
        }

        //yenı ıslem artık bu kullanılıcak 

        private int _b;

        public int b { get => _b; set => _b = value; }  //kısa versıyonu
        public int b1 //uzun versıyonu tek adımlı ıcın ustekını kullanırız
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }


    }

    #endregion
}
