using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefaceDeneme
{
    public class Test
    {
        private readonly ITest test;
        public Test(şekil şekil = şekil.kare)
        {
            if (şekil == şekil.kare)
            {
                test = new Kare();
            }
            else
            {
                test = new Üçgen();
            }
        }

        public int çevre(int birkenear) => test.çevre(birkenear);
        public int alan(int yükseklik, int kenar) => test.alan(yükseklik, kenar);
    }

    public interface ITest
    {
        int çevre(int birkenar);
        int alan(int yukseklık, int kenar);
    }

    public enum şekil
    {
        üçgen,
        kare
    }

    public class Kare : ITest
    {
        public int alan(int yukseklık, int kenar)
        {
            return yukseklık * kenar;
        }

        public int çevre(int birkenar)
        {
            return birkenar * 4;
        }
    }

    public class Üçgen : ITest
    {
        public int alan(int yukseklık, int kenar)
        {
            return yukseklık * kenar / 2;
        }

        public int çevre(int birkenar)
        {
            return birkenar * 3;
        }
    }
}
