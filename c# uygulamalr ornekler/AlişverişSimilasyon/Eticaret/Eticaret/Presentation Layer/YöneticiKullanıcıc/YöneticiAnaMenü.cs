using Eticaret.Datta_Access.DbGirişEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Presentation_Layer.YöneticiKullanıcıc
{
    public class YöneticiAnaMenü
    {

        public static void Menü(Yönetici yönetici)
        {
            Console.WriteLine($"Yöneticielr menüsüne hoşgeldiniz:{yönetici.İsim}");

        }
    }
}
