namespace Zadanie5_1
{
    enum Kierunek
    {
        wschód,
        zachód,
        północ,
        południe
    }

    enum Zachmurzenie
    {
        duże,
        średnie,
        małe,
        brak
    }

    struct Pogoda
    {
        private int czasPomiaru;
        private double temperatura;
        private double predkoscWiatru;
        private double wilgotnosc;
        private Kierunek kierunek;
        private Zachmurzenie zachmurzenie;

        public Pogoda(int czasPomiaru, double temperatura, double predkoscWiatru, double wilgotnosc, Kierunek kierunek, Zachmurzenie zachmurzenie)
        {
            this.czasPomiaru = czasPomiaru;
            this.temperatura = temperatura;
            this.predkoscWiatru = predkoscWiatru;
            this.wilgotnosc = wilgotnosc;
            this.kierunek = kierunek;
            this.zachmurzenie = zachmurzenie;
        }

        public override string ToString()
        {
            return $"Czas pomiaru [s]: {czasPomiaru}\tTemperatura: {temperatura}\tPrędkość wiatru: {predkoscWiatru}\tWilgotnosc: {wilgotnosc}\tKierunek: {kierunek}\tZachmurzenie: {zachmurzenie}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pogoda[] prognoza = new Pogoda[2];
            prognoza[0] = new Pogoda(120, 25.5, 0.9, 1.0, Kierunek.wschód, Zachmurzenie.duże);
            prognoza[1] = new Pogoda(150, 19.2, 0.1, 0.0, Kierunek.północ, Zachmurzenie.brak);

            foreach(var p in prognoza)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}