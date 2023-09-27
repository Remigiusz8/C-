using System.Reflection.Metadata;

namespace Zadanie4a
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

        public int CompareTo(string parametr, Klient other)
        {
            switch (parametr)
            {
                case "nazwisko": return this.Nazwisko.CompareTo(other.Nazwisko);

                case "imie": return this.Imie.CompareTo(other.Imie);

                case "miasto": return this.Miasto.CompareTo(other.Miasto);

                case "ulica": return this.Ulica.CompareTo(other.Ulica);

                default: return -1;
            }
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

        public int CompareTo(string parametr, Pracownik other)
        {
            switch (parametr)
            {
                case "nazwisko": return this.Nazwisko.CompareTo(other.Nazwisko);

                case "imie": return this.Imie.CompareTo(other.Imie);

                case "miasto": return this.Miasto.CompareTo(other.Miasto);

                case "ulica": return this.Ulica.CompareTo(other.Ulica);

                default: return -1;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Klient> klienci = new List<Klient>();
            klienci.Add(new Klient("Jan", "Nowak", "Praga", "Słoneczna", 2));
            klienci.Add(new Klient("Tomasz", "Jędza", "Warszawa", "Złota", 40));
            klienci.Add(new Klient("Adam", "Bzyk", "Bąków", "Zielona", 16));
            List<Pracownik> pracownicy = new List<Pracownik>();
            pracownicy.Add(new Pracownik("Arek", "Papuga", "Wisła", "Polna", 7));
            pracownicy.Add(new Pracownik("Krzyś", "Kubik", "Ustroń", "Wielka", 112));
            pracownicy.Add(new Pracownik("Przemek", "Janusz", "Rogów", "Mała", 1));

            foreach (Klient czlowiek in klienci)
            {
                Console.WriteLine(czlowiek.ToString());
            }
            Console.WriteLine();

            foreach (Pracownik czlowiek in pracownicy)
            {
                Console.WriteLine(czlowiek.ToString());
            }

            List<Klient> klientPrinter = new List<Klient>();
            List<Pracownik> pracownikPrinter = new List<Pracownik>();

            Console.WriteLine();
            Console.WriteLine("Wybierz kryterium sortowania:");
            Console.WriteLine();
            Console.WriteLine("- nazwisko");
            Console.WriteLine("- imie");
            Console.WriteLine("- miasto");
            Console.WriteLine("- ulica");
            Console.Write("Wybór: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "nazwisko":
                    klienci.Sort((k1, k2) => k1.Nazwisko.CompareTo(k2.Nazwisko));
                    pracownicy.Sort((p1, p2) => p1.Nazwisko.CompareTo(p2.Nazwisko));
                    foreach (Klient czlowiek in klienci)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    Console.WriteLine();
                    foreach (Pracownik czlowiek in pracownicy)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    break;
                case "imie":
                    klienci.Sort((k1, k2) => k1.Imie.CompareTo(k2.Imie));
                    pracownicy.Sort((p1, p2) => p1.Imie.CompareTo(p2.Imie));
                    foreach (Klient czlowiek in klienci)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    Console.WriteLine();
                    foreach (Pracownik czlowiek in pracownicy)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    break;
                case "miasto":
                    klienci.Sort((k1, k2) => k1.Miasto.CompareTo(k2.Miasto));
                    pracownicy.Sort((p1, p2) => p1.Miasto.CompareTo(p2.Miasto));
                    foreach (Klient czlowiek in klienci)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    Console.WriteLine();
                    foreach (Pracownik czlowiek in pracownicy)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    break;
                case "ulica":
                    klienci.Sort((k1, k2) => k1.Ulica.CompareTo(k2.Ulica));
                    pracownicy.Sort((p1, p2) => p1.Ulica.CompareTo(p2.Ulica));
                    foreach (Klient czlowiek in klienci)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    Console.WriteLine();
                    foreach (Pracownik czlowiek in pracownicy)
                    {
                        Console.WriteLine(czlowiek.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór");
                    break;
            }
        }
    }
}