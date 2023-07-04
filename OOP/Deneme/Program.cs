using System;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Deneme.kayıt);
            Deneme deneme = new Deneme();
            Deneme deneme1 = new Deneme();
            Deneme deneme2 = new Deneme();
            Console.WriteLine(Deneme.kayıt);
            Console.ReadLine();
        }
    }

     class  Deneme
    {
        public static int kayıt = 0;
        public Deneme()
        {
                kayıt++;
        }

    }
}
