namespace Karakter
{
    public class karakterStats
    {
        private List<Karakter> karakterek;

        public karakterStats(List<Karakter> karakterek) { this.karakterek = karakterek; }

        public void ElegNagySzintuE(int szint)
        {
            System.Console.WriteLine("\n"+szint+"-nél nagyobb szintű karakterek:");
            foreach (var item in karakterek)
            {
                if (item.Szint > szint)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}