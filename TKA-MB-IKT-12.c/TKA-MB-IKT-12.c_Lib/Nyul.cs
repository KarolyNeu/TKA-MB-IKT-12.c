using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKA_MB_IKT_12.c_Lib
{
    public class Nyul
    {
        public Nyul(int nyulEletero)
        {
            this.NyulElete = nyulEletero;
        }

        public static void FuFogyasztas(Nyul nyul)
        {
            nyul.NyulElete++;
        }

        public static void PontokCsokkenese(Nyul nyul)
        {
            nyul.NyulElete--;
        }

        public int NyulElete { get; set; }
    }
}
