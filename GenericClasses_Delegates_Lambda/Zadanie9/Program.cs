namespace Zadanie9
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public static int liczbaObiektów = 0;

        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            liczbaObiektów++;
        }

        public static string IloscObiektow()
        {
            return $"Liczba obiektów klasy Osoba: {liczbaObiektów.ToString()}";
        }
    }

    class Towar
    {
        private string symbol;
        private string nazwa;
        private double cena;

        public static int liczbaObiektow = 0;

        public Towar(string symbol, string nazwa, double cena)
        {
            this.symbol = symbol;
            this.nazwa = nazwa;
            this.cena = cena;
            liczbaObiektow++;
        }

        public static string IloscObiektow()
        {
            return $"Liczba obiektów klasy Towar: {liczbaObiektow.ToString()}";
        }
    }

    delegate string Delegat();

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jan", "Kowal", 20);
            Osoba o2 = new Osoba("Tomasz", "Jakubiak", 23);
            Osoba o3 = new Osoba("Amadeusz", "Filc", 22);
            Towar t1 = new Towar("TK-0212", "Mop", 19.99);
            Towar t2 = new Towar("MC-011", "Cheeseburger", 6.99);

            Delegat del = new Delegat(Osoba.IloscObiektow);
            Delegat del2 = new Delegat(Towar.IloscObiektow);

            Console.WriteLine(del());
            Console.WriteLine(del2());
        }
    }
}