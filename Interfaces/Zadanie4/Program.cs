namespace Zadanie4
{
    interface IAdres
    {
        string Miasto { get; }
        string Ulica { get; }
        int Numer { get; }
    }
    interface IOsoba : IAdres
    {
        string Imie { get; }
        string Nazwisko { get; }
    }

    public class Klient : IOsoba
    {
        public string Miasto { get; }
        public string Ulica { get; }
        public int Numer { get; }
        public string Imie { get; }
        public string Nazwisko { get; }

        public Klient(string Imie, string Nazwisko, string Miasto, string Ulica, int Numer)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Miasto = Miasto;
            this.Ulica = Ulica;
            this.Numer = Numer;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"Klient: {Imie} {Nazwisko}\nUlica {Ulica} {Numer}\n{Miasto}";
        }
    }

    public class Pracownik : IOsoba
    {
        public string Miasto { get; }
        public string Ulica { get; }
        public int Numer { get; }
        public string Imie { get; }
        public string Nazwisko { get; }

        public Pracownik(string Imie, string Nazwisko, string Miasto, string Ulica, int Numer)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Miasto = Miasto;
            this.Ulica = Ulica;
            this.Numer = Numer;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"Pracownik: {Imie} {Nazwisko}\nUlica {Ulica} {Numer}\n{Miasto}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IOsoba> osoby = new List<IOsoba>();
            osoby.Add(new Klient("Jan", "Nowak", "Praga", "Słoneczna", 2));
            osoby.Add(new Klient("Tomasz", "Jędza", "Warszawa", "Złota", 40));
            osoby.Add(new Klient("Adam", "Bzyk", "Bąków", "Zielona", 16));
            osoby.Add(new Pracownik("Arek", "Papuga", "Wisła", "Polna", 7));
            osoby.Add(new Pracownik("Krzyś", "Kubik", "Ustroń", "Wielka", 112));
            osoby.Add(new Pracownik("Przemek", "Janusz", "Rogów", "Mała", 1));

            foreach(IOsoba czlowiek in osoby)
            {
                Console.WriteLine(czlowiek.ToString());
            }
        }
    }
}