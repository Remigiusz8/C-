namespace Zadanie5
{
    class Szescian
    {
        protected string nazwa;
        protected double krawedz;

        public Szescian(string nazwa, double krawedz)
        {
            this.nazwa = nazwa;
            this.krawedz = krawedz;
        }

        public virtual double Objetosc()
        {
            return krawedz * krawedz * krawedz;
        }

        public override string ToString()
        {
            return $"{nazwa} {krawedz} {Objetosc()}";
        }
    }
    
    class Prostopadloscian : Szescian
    {
        private double krawedz2;
        private double krawedz3;

        public Prostopadloscian(string nazwa, double krawedz, double krawedz2, double krawedz3) : base(nazwa, krawedz)
        {
            this.krawedz2 = krawedz2;
            this.krawedz3 = krawedz3;
        }

        public override double Objetosc()
        {
            return krawedz * krawedz2 * krawedz3;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {krawedz2} {krawedz3}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szescian[] bryly = new Szescian[3];
            bryly[0] = new Szescian("Jeden", 4);
            bryly[1]= new Prostopadloscian("Dwa", 2, 3, 5);
            bryly[2] = new Prostopadloscian("Trzy", 5, 3, 7);

            foreach (var b in bryly)
            {
                Console.WriteLine(b.ToString());
            }
        }
    }
}