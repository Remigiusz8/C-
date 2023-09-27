namespace Zadanie2_1
{
    struct Ulamki
    {
        double licznik;
        double mianownik;
        public Ulamki(double licznik, double mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public Ulamki Dodaj(Ulamki jeden)
        {
            double finalLicznik = licznik * jeden.mianownik;
            double finalMianownik = mianownik * jeden.mianownik;
            double drugiLicznik = jeden.licznik * mianownik;
            double nowyLicznik = finalLicznik + drugiLicznik;

            double nwd = NWD(nowyLicznik, finalMianownik);

            return new Ulamki(nowyLicznik / nwd, finalMianownik / nwd);
        }
        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }

        public static double NWD(double a, double b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;

                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var one = new Ulamki(2, 5);
            var two = new Ulamki(1, 10);

            Console.WriteLine("{0} + {1} = {2}", one, two, one.Dodaj(two));
        }
    }
}