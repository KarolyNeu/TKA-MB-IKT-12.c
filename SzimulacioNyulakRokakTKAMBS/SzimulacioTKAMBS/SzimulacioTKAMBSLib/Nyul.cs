namespace SzimulacioTKAMBSLib
{
    public class Nyul : Entity
    {
        public Nyul(int eletero)
        {
            this.eletero = eletero;
        }

        public static void FuEves(Nyul nyul)
        {
            nyul.eletero++;
        }


        public override void korcsokkenes()
        {
            eletero--;
        }
    }
}