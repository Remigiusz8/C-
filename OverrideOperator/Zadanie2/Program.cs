namespace Zadanie2
{
    struct Ulamek
    {
        double licznik { get; set; }
        double mianownik { get; set; }

        public Ulamek(double licznik, double mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public static Ulamek operator + (Ulamek u1, Ulamek u2)
        {
            return new Ulamek((u1.licznik * u2.mianownik) + (u2.licznik * u1.mianownik), u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator - (Ulamek u1, Ulamek u2)
        {
            return new Ulamek((u1.licznik * u2.mianownik) - (u2.licznik * u1.mianownik), u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator * (Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.licznik, u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator * (Ulamek u1, int factor)
        {
            return new Ulamek(factor * u1.licznik, u1.mianownik);
        }

        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek(10, 2);
            Ulamek u2 = new Ulamek(3, 4);

            Console.WriteLine(u1 + u2);
            Console.WriteLine(u1 - u2);
            Console.WriteLine(u1 * u2);
            Console.WriteLine(u1 * 2);
            Console.WriteLine(u2 * 3);
        }
    }
}