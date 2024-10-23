namespace SzimulacioTKAMBSLib
{
    public class Roka : Entity
    {
        public Roka(int eletero)
        {
            this.eletero = eletero;
        }


        public static void NyulEves(Roka roka)
        {
            roka.eletero += 3;
        }


        public override void korcsokkenes()
        {
            eletero--;
        }
    }
}