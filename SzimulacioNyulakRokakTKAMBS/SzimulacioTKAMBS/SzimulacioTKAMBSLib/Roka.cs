using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzimulacioTKAMBSLib
{
    internal class Roka : Entity
    {
        public Roka(int eletero)
        {
            this.RokaEletero = eletero;
        }

        public static void KorCsokkenes(Roka roka)
        {
            roka.RokaEletero--;
        }

        public static void NyulEves(Roka roka)
        {
            roka.RokaEletero += 3;
        }

        public override void KorCsokkenes()
        {
            RokaEletero--;
        }
        public int RokaEletero { get; set; }

    }
}
