namespace Zadanie2a
{
    enum KierunekWiatru
    {
        polnoc,
        poludnie,
        wschod,
        zachod
    }

    enum Zachmurzenie
    {
        duze,
        srednie,
        male,
        brak
    }

    class Pogoda
    {
        public DateTime czasPomiaru;
        public int temperatura;
        public int predkoscWiatru;
        public int wilgotnosc;
        public KierunekWiatru kierunekWiatru;
        public Zachmurzenie zachmurzenie;

        public Pogoda(DateTime czas, int tem, int pred, int wilg, KierunekWiatru wiatr, Zachmurzenie zach)
        {
            czasPomiaru = czas;
            temperatura = tem;
            predkoscWiatru = pred;
            wilgotnosc = wilg;
            kierunekWiatru = wiatr;
            zachmurzenie = zach;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pogoda> prognoza = new List<Pogoda>();
            Random r = new Random();

            DateTime time = new DateTime(2023, 06, 30);
            for (int i = 0; i < 1000; i++)
            {
                time = time.AddHours(1);
                int temperatura = r.Next(-20, 42);
                int predkoscWiatru = r.Next(0, 200);
                int wilgotnosc = r.Next(0, 10);
                KierunekWiatru kierunekWiatru = (KierunekWiatru)r.Next(4);
                Zachmurzenie zachmurzenie = (Zachmurzenie)r.Next(4);

                Pogoda p = new Pogoda(time, temperatura, predkoscWiatru, wilgotnosc, kierunekWiatru, zachmurzenie);

                prognoza.Add(p);
            }

            string sciezka = @"C:\Users\Remek\source\repos\Zadanie2a\Prognoza.csv";
            StreamWriter sw = new StreamWriter(sciezka);

            if (!File.Exists(sciezka))
            {
                File.Create(sciezka);
            }

            foreach (Pogoda p in prognoza)
            {
                sw.WriteLine($"{p.czasPomiaru};{p.temperatura};{p.predkoscWiatru};{p.wilgotnosc};{p.kierunekWiatru};{p.zachmurzenie}");
            }
            sw.Flush();
            sw.Close();

            Console.WriteLine("Wykonano");


            List<Pogoda> kolekcja = WczytajZPlikuCSV(sciezka);
        }

        static List<Pogoda> WczytajZPlikuCSV(string sciezka)
        {
            List<Pogoda> kolekcja = new List<Pogoda>();

            using (StreamReader reader = new StreamReader(sciezka))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    DateTime czasPomiaru = DateTime.Parse(values[0]);
                    int temperatura = int.Parse(values[1]);
                    int predkoscWiatru = int.Parse(values[2]);
                    KierunekWiatru kierunekWiatru = (KierunekWiatru)Enum.Parse(typeof(KierunekWiatru), values[3]);
                    int wilgotnosc = int.Parse(values[4]);
                    Zachmurzenie zachmurzenie = (Zachmurzenie)Enum.Parse(typeof(Zachmurzenie), values[5]);

                    Pogoda pogoda = new Pogoda(czasPomiaru, temperatura, predkoscWiatru, kierunekWiatru, wilgotnosc, zachmurzenie);
                    kolekcja.Add(pogoda);
                }
            }

            return kolekcja;
        }

        static void WyswietlPogode(List<Pogoda> kolekcja)
        {
            Console.WriteLine("Czas Pomiaru        |  Temperatura | Predkosc Wiatru  | Kierunek Wiatru     |    Wilgotnosc  | Zachmurzenie");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            foreach (Pogoda pogoda in kolekcja)
            {
                Console.WriteLine("{0,-19} | {1,12} | {2,16} | {3,19} | {4,13} | {5,15}",
                    pogoda.CzasPomiaru.ToString("yyyy-MM-dd HH:mm:ss"),
                    pogoda.Temperatura.ToString("0.00"),
                    pogoda.PredkoscWiatru.ToString("0.00"),
                    pogoda.KierunekWiatru.ToString(),
                    pogoda.Wilgotnosc,
                    pogoda.Zachmurzenie.ToString());
            }
        }

        static int PodsumowanieBrakuChmur(List<Pogoda> kolekcja)
        {
            int ilosc = 0;

            foreach (Pogoda pogoda in kolekcja)
            {
                if (pogoda.Zachmurzenie == Zachmurzenie.Brak)
                {
                    ilosc++;
                }
            }

            return ilosc;
        }

        static int PodsumowanieWilgotnoscPowyzej80(List<Pogoda> kolekcja)
        {
            int ilosc = 0;

            foreach (Pogoda pogoda in kolekcja)
            {
                if (pogoda.Wilgotnosc > 80)
                {
                    ilosc++;
                }
            }

            return ilosc;
        }
    }
}
}