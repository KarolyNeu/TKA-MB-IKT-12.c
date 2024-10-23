using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKA_MB_IKT_12.c_Lib
{
    internal class Fu
    {
        public Fu(int hossz)
        {
            this.fuHossz = hossz;
        }

        public static void PontokCsokkenese()
        {
        //    hossz--;
        }
        public static void FuNovekedese(Fu fu)
        {
            fu.fuHossz++;
        }

        public static void FuEltunese(Fu fu)
        {
            fu.fuHossz--;
        }

        public int fuHossz { get; set; }
    }
}
