namespace Karakter
{
    public class karakter
    {
        private string nev;
        private int szint;
        private int eletero;
        private int ero;

        public karakter(string nev, int szint, int eletero, int ero)
        {
            this.nev = nev;
            this.szint = szint;
            this.eletero = eletero;
            this.ero = ero;
        }

        public string Nev{ get => nev; set => nev = value; }
        public int Szint{ get => szint; set => szint = value; }
        public int Eletero{ get => eletero; set => eletero = value; }
        public int Ero{ get => ero; set => ero = value;}


        public override string ToString()
        {
            return $"Név: {nev}, Szint: {szint}, Életerő: {eletero}, Erő: {ero}";
        }
    }
}