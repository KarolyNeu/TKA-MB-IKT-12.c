using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzimulacioTKAMBSLib
{
    internal class Nyul : Entity
    {
        public Nyul(int eletero)
        {
            this.NyulEletero = eletero;
        }

        public static void FuEves(Nyul nyul)
        {
            nyul.NyulEletero++;
        }

        public override void KorCsokkenes()
        {
            NyulEletero--;
        }

        public static void KorCsokkenes(Nyul nyul)
        {
            nyul.NyulEletero--;
        }

        public int NyulEletero { get; set; }
    }
}
