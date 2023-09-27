using System.Text.RegularExpressions;

namespace Zadanie2
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

            string sciezka = @"C:\Users\Remek\source\repos\Zadanie2\Prognoza.csv";
            StreamWriter sw = new StreamWriter(sciezka);

            if (!File.Exists(sciezka))
            {
                File.Create(sciezka);
            }

            foreach(Pogoda p in prognoza)
            {
                sw.WriteLine($"{p.czasPomiaru};{p.temperatura};{p.predkoscWiatru};{p.wilgotnosc};{p.kierunekWiatru};{p.zachmurzenie}");
            }
            sw.Flush();
            sw.Close();

            Console.WriteLine("Wykonano");
        }
    }
}