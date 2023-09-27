namespace Zadanie6_1
{
    struct KandydatNaStudia
    {
        private string nazwiskoKandydata;
        private string imieKandydata;
        private int punktyMatematyka;
        private int punktyInformatyka;
        private int punktyJezykObcy;

        public KandydatNaStudia(string naz, string imie, int matma, int infa, int obcy)
        {
            this.nazwiskoKandydata = naz;
            this.imieKandydata = imie;
            this.punktyMatematyka = matma;
            this.punktyInformatyka = infa;
            this.punktyJezykObcy = obcy;
        }

        private double Punkty()
        {
            return punktyMatematyka * 0.6 + punktyInformatyka * 0.5 + punktyJezykObcy * 0.2;
        }

        public override string ToString()
        {
            return $"{nazwiskoKandydata} {Punkty()}"; 
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia[] lista = new KandydatNaStudia[3];

            lista[0] = new KandydatNaStudia("Konik", "Wiki", 69, 78, 97);
            lista[1] = new KandydatNaStudia("Woźniak", "Wiktoria", 20, 19, 60);
            lista[2] = new KandydatNaStudia("Kamczyk", "Natalia", 24, 42, 60);

            foreach(var i in lista)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}