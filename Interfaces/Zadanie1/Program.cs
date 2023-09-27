namespace Zadanie1
{
    interface IWypisz
    {
        void Wypisz();
    }

    public class Towar
    {
        public string nazwa { get; set; }
        public double cena { get; set; }
        public int ilosc { get; set; }

        public Towar(string nazwa, double cena, int ilosc)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
        }

        public override string ToString()
        {
            return $"Nazwa: {nazwa}, Cena: {cena}, Ilość: {ilosc}";
        }
    }

    public class Osoba
    {
        public string imie;
        public string nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return $"Imie: {imie}, Nazwisko: {nazwisko}";
        }
    }

    public class Towary : List<Towar>, IWypisz
    {
        public List<Towar> towary = new List<Towar>();

        public void Add(Towar other)
        {
            towary.Add(other);
        }

        public void Wypisz()
        {
            for(int i = 0; i < towary.Count; i++)
            {
                Console.WriteLine($"{i+1}. {towary[i].ToString()}");
            }
        }
    }

    public class Osoby : List<Osoba>, IWypisz
    {
        public List<Osoba> osoby = new List<Osoba>();

        public void Wypisz()
        {
            for(int i = 0; i < osoby.Count; i++)
            {
                Console.WriteLine($"Pan/Pani {osoby[i].ToString()}");
            }
        }

        public void Add(Osoba other)
        {
            osoby.Add(other);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoby ludzie = new Osoby();
            ludzie.Add(new Osoba("Jan", "Mul"));
            ludzie.Add(new Osoba("Kamil", "Woll"));
            ludzie.Add(new Osoba("Andrzej", "Kul"));
            ludzie.Add(new Osoba("Mati", "Zul"));

            Towary towary = new Towary();
            towary.Add(new Towar("JKW-1234", 32.53, 2));
            towary.Add(new Towar("OW-09a", 12.33, 7));
            towary.Add(new Towar("POLA", 9.98, 34));
            towary.Add(new Towar("AWDN", 42.57, 1));

            ludzie.Wypisz();
            towary.Wypisz();
        }
    }
}