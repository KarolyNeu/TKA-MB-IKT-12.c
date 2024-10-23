namespace SzimulacioTKAMBSLib
{
    public class Fu : Entity
    {
        public Fu(int hossz)
        {
            this.FuHossz = hossz;
        }

        public static void FuNovekedes(Fu fu)
        {
            fu.FuHossz++;
        }

        public static void FuEltunes(Fu fu)
        {
            fu.FuHossz--;
        }

        public override void korcsokkenes()
        {
            FuHossz--;
        }

        public int FuHossz { get; set; }
    }
}