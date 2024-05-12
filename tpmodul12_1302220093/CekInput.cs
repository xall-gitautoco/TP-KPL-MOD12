using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul12_1302220093
{
    internal class CekInput
    {
        public static string CariTandaBilangan(int a)
        {
            string hasil;

            if (a < 0)
            {
                hasil = "Negatif";
            }
            else if (a > 0)
            {
                hasil = "Positif";
            }
            else
            {
                hasil = "Nol";
            }

            return hasil;

        }
    }
}
