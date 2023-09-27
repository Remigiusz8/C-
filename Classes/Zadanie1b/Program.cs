using System.Security.Cryptography;

namespace Zadanie1b
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

        public static int MaxPole(Prostokat[] rects)
        {
            int pole = 0;

            foreach (Prostokat p in rects)
            {
                if (p.Powierzchnia() > pole)
                {
                    pole = p.Powierzchnia();
                }
            }

            return pole;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat[] rectangles = new Prostokat[3];

            rectangles[0] = new Prostokat(2, 6);
            rectangles[1] = new Prostokat(6, 7);
            rectangles[2] = new Prostokat(2, 1);

            foreach (var p in rectangles)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine(Prostokat.MaxPole(rectangles));
        }
    }
}