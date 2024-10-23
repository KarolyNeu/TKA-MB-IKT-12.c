using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKA_MB_IKT_12.c_Lib
{
    public class Roka
    {
        public Roka(int RokaEletero)
        {
            this.RokaElete = RokaEletero;
        }

        public static void NyulOles(Roka roka)
        {
            roka.RokaElete += 3;
        }
        public static void PontokCsokkenese(Roka roka)
        {
            roka.RokaElete--;
        }
        public int RokaElete { get; set; }
    }

}