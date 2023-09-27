using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Zadanie1
{
    public class Pracownik
    {
        private string imie;
        private string nazwisko;
        private int godziny;
        private int stawka;

        public Pracownik(string imie, string nazwisko, int godziny, int stawka)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.godziny = godziny;
            this.stawka = stawka;
        }
        
        public int Pensja()
        {
            return godziny * stawka;
        }

        public override string ToString()
        {
            return $"{imie};\t{nazwisko.PadRight(10)};\t{godziny};\t{stawka};\t{Pensja()};";
        }
    }
    [Obsolete("nie korzystaj z tego")]
    public class Pracownicy
    {
        List<Pracownik> ludzie = new List<Pracownik>();

        public Pracownicy() { }

        public void PokazListe()
        {
            Console.WriteLine("Imie Nazwisko Godziny Stawka Pensja");
            for (int i = 0; i < ludzie.Count; i++)
            {
                Console.WriteLine(ludzie[i].ToString());
            }
        }

        public void Wczytaj(string sciezka)
        {
            StreamReader sr = new StreamReader(sciezka);
            string line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                string[] dane = line.Split(';');
                int liczba1, liczba2;
                if (!int.TryParse(dane[2], out liczba1))
                {
                    throw new Exception("Fail");
                }
                if (!int.TryParse(dane[3], out liczba2))
                {
                    throw new Exception("Fail2");
                }
                ludzie.Add(new Pracownik(dane[0], dane[1], int.Parse(dane[2]), int.Parse(dane[3])));
            }
        }

        public void Zapisz(string sciezka)
        {
            StreamWriter sw = new StreamWriter(sciezka);

            if (!File.Exists(sciezka))
            {
                File.Create(sciezka);
            }

            for(int i = 0; i < ludzie.Count; i++)
            {
                sw.WriteLine($"{ludzie[i].ToString()}");
            }
            sw.Flush();
            sw.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pracownicy pracownicy = new Pracownicy();
            string sciezka = @"C:\Users\Remek\source\repos\Zadanie1\pracownicy.csv";
            string sciezka2 = @"C:\Users\Remek\source\repos\Zadanie1\pracownicy_pensja.csv";

            pracownicy.PokazListe();
            Console.WriteLine();
            pracownicy.Wczytaj(sciezka);
            pracownicy.PokazListe();
            Console.WriteLine();
            pracownicy.Zapisz(sciezka2);
        }
    }
}