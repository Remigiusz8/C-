using System.Runtime.CompilerServices;

namespace Zadanie2
{
    class Prostokat
    {
        private int dlugosc { get; set; }
        private int szerokosc { get; set; }

        public Prostokat(int dlugosc, int szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        public int Pole()
        {
            return dlugosc * szerokosc;
        }

        public override string ToString()
        {
            return $"Długość: {dlugosc} Szerokość: {szerokosc}";
        }
    }
    class Blat : Prostokat
    {
        public enum Rodzaj
        {
            granitowy = 600,
            drewniany = 250
        }

        private Rodzaj rodzaj;

        public Blat(int dlugosc, int szerokosc, Rodzaj rodzaj) : base(dlugosc, szerokosc)
        {
            this.rodzaj = rodzaj;
        }

        public int Pole()
        {
            return base.Pole();
        }

        public int Koszt()
        {
            int cena = (int)rodzaj;
            return Pole() * cena;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p = new Prostokat(4, 6);
            Blat b1 = new Blat(13, 10, Blat.Rodzaj.granitowy);

            Console.WriteLine(p.ToString());
            Console.WriteLine(b1.ToString());

            Console.WriteLine(p.Pole());
            Console.WriteLine("Pole: {0}", b1.Pole());
            Console.WriteLine("Koszt: {0}", b1.Koszt());
        }
    }
}