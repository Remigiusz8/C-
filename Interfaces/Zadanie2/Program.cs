namespace Zadanie2
{
    interface IWypisz : IComparable<IWypisz>
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

        public int CompareTo(IWypisz other)
        {
            if (this == null) return 1;
            return cena.CompareTo(other.cena);
        }

        public void Wypisz()
        {
            for (int i = 0; i < towary.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {towary[i].ToString()}");
            }
        }
    }

    public class Osoby : List<Osoba>, IWypisz
    {
        public List<Osoba> osoby = new List<Osoba>();

        public void Wypisz()
        {
            for (int i = 0; i < osoby.Count; i++)
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
            Osoby osoby = new Osoby();
            osoby.Add(new Osoba("Jan", "Bednarek"));
            osoby.Add(new Osoba("Tomasz", "Kąpiel"));
            osoby.Add(new Osoba("Piotr", "Zieliński"));
            osoby.Add(new Osoba("Robert", "Lewandowski"));

            Towary towary = new Towary();
            towary.Add(new Towar("Kiełbasa", 19.29, 2));
            towary.Add(new Towar("Chleb", 7.29, 1));
            towary.Add(new Towar("Szynka", 10.39, 5));
            towary.Add(new Towar("Ser", 9.20, 3));

            towary.Wypisz();
            osoby.Wypisz();
        }
    }
}