namespace Zadanie4
{
    class Prostopadloscian
    {
        private int dlugosc { get; set; }
        private int szerokosc { get; set; }
        private int wysokosc { get; set; }

        public Prostopadloscian (int dlugosc, int szerokosc, int wysokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
        }

        public int Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }

        public void Compare(Prostopadloscian p)
        {
            double o = Objetosc();

            if(o > p.Objetosc())
            {
                Console.WriteLine("Objetosc pierwszego jest wieksza");
            }
            else if (o < p.Objetosc())
            {
                Console.WriteLine("Objetosc drugiego jest wieksza");
            }
            else { Console.WriteLine("Objetosci sa takie same"); }

        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian jeden = new Prostopadloscian(2,3,4);
            Prostopadloscian dwa = new Prostopadloscian(1,3,8);

            Console.WriteLine(jeden.Objetosc());
            Console.WriteLine(dwa.Objetosc());

            jeden.Compare(dwa);
        }
    }
}