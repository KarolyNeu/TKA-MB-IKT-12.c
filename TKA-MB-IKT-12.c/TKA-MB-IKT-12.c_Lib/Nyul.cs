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
        public int NyulElete { get; set; }
        public static void FuFogyasztas(Nyul nyul)
        {
            nyul.NyulElete++;
        }

        public static void KorokCsokkenese(Nyul nyul)
        {
            nyul.NyulElete--;
        }

        public override void KorokCsokkenese()
        {
            NyulElete--;
        }
    }
}
