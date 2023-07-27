using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegateler
{
    delegate void Tets();
    
    public static class eventdenemee
    {
        static event Tets x {
            add
            {
                //methot eklendıgınde calısacak kısım
                Console.WriteLine("Added");
            }
            remove
            {
                //metot cıkarılınca calısacak kısım 
                Console.WriteLine("Removed");
            }
        }

        static event EventHandler myEvent;
        public static void Tetssayfası()
        {
            //Tets z = Deneme;
            x += Deneme;
            x += Deneme;
            x -= Deneme;
            x += new Tets(Deneme);

            myEvent += Eventdenemee_myEvent;

            Button btn = new() { Tex = "clıc", Height = 15, Width = 40 };
            Buttonİnfo btni = new() { Date = "2020" };

            myEvent(btn, btni);
        }

        private static void Eventdenemee_myEvent(object? sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).ToString());
            Console.WriteLine(((Buttonİnfo)e).Date);
        }

        public static void Deneme()
        {
            Console.WriteLine("Hello");
        }
        class Button
        {
            public string Tex;
            public double Width;
            public double Height;
        }
        class Buttonİnfo:EventArgs
        {
            public string Date;
        }
    }

    
}


