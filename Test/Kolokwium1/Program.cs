using System.Runtime.CompilerServices;

namespace Kolokwium1
{
    enum Rodzaj
    {
        uniwersalny,
        sportowy,
        turystyczny,
        skuter,
        terenowy
    }
    struct Motocykl
    {
        private string marka { get; set; }
        private string model { get; set; }
        private Rodzaj rodzaj { get; set; }
        public int rokProdukcji { get; set; }
        private double cena { get; set; }

        public Motocykl(string marka, string model, Rodzaj rodzaj, int rokProdukcji, double cena)
        {
            this.marka = marka;
            this.model = model;
            this.rodzaj = rodzaj;
            this.rokProdukcji = rokProdukcji;
            this.cena = cena;
        }

        public static Motocykl operator +(Motocykl m1, Motocykl m2)
        {
            Motocykl m = new Motocykl();
            return new Motocykl(m.marka, m.model, m.rodzaj, m.rokProdukcji, m1.cena + m2.cena);
        }

        public override string ToString()
        {
            return $"{marka}\t\t{model}\t\t{rodzaj}\t\t{rokProdukcji}\t\t{cena.ToString("0.00")}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Motocykl[] moto = new Motocykl[4];

            moto[0] = new Motocykl("Yamaha", "M1", Rodzaj.uniwersalny, 1999, 300.50);
            moto[1] = new Motocykl("FastMot", "U2", Rodzaj.sportowy, 2012, 150.56);
            moto[2] = new Motocykl("Ford", "gilette", Rodzaj.turystyczny, 2000, 400.20);
            moto[3] = new Motocykl("Suzuki", "terrain", Rodzaj.terenowy, 2012, 348.37);

            foreach (Motocykl m in moto)
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine();
            Console.WriteLine(moto[0] + moto[1]);

            Console.WriteLine("Wpisz rok produkcji ");
            int year = int.Parse(Console.ReadLine());

        }
    }
}