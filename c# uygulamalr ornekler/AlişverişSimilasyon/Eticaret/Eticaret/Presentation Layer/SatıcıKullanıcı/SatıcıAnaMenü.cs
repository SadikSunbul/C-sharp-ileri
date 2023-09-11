using Eticaret.Datta_Access.DbGirişEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Presentation_Layer.NormalKulalnıcı
{
    public class SatıcıAnaMenü
    {

        public static void Menü(Satıcı kullanıcı)
        {
            Console.WriteLine($"Satıcı Ana menüsüne Hoş geldiniz:{kullanıcı.İsim}");

        }
    }
}
