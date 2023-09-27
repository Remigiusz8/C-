using System.Runtime.CompilerServices;

namespace Zadanie1
{
    class Prostokat
    {
        private int dlugosc;
        private int szerokosc;

        public Prostokat() { }

        public Prostokat(int dlugosc, int szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private int Powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private int Obwod()
        {
            return 2 * szerokosc + 2 * dlugosc;
        }

        public override string ToString()
        {
            return $"Powierzchnia: {Powierzchnia()}. Obwód: {Obwod()}";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat(2, 4);
            Prostokat p2 = new Prostokat(4, 5);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}