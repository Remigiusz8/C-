namespace Kolokwium3
{
    class Pensja
    {
        protected double stawkaGodzinowa { get; set; }
        protected int liczbaGodzinPracy { get; set; }

        public Pensja() { }

        public Pensja(double stawka, int liczba)
        {
            stawkaGodzinowa = stawka;
            liczbaGodzinPracy = liczba;
        }

        public virtual double ObliczPensje()
        {
            return liczbaGodzinPracy * stawkaGodzinowa;
        }

        public override string ToString()
        {
            return $"stawka: {stawkaGodzinowa.ToString("0.00")}\tliczba godzin pracy: {liczbaGodzinPracy}\tpensja: {ObliczPensje().ToString("0.00")}";
        }
    }

    class PensjaKierowcy : Pensja
    {
        private double procentPremii;

        public PensjaKierowcy(double stawka, int liczba, double procentPremii) : base(stawka, liczba)
        {
            this.procentPremii = procentPremii;
        }

        public override double ObliczPensje()
        {
            return liczbaGodzinPracy * stawkaGodzinowa * (1 + procentPremii);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tprocent premii: {procentPremii.ToString("0.00")}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pensja[] pensja = new Pensja[4];

            pensja[0] = new Pensja(18.60, 16);
            pensja[1] = new Pensja(19.99, 34);
            pensja[2] = new PensjaKierowcy(20.00, 12, 0.12);
            pensja[3] = new PensjaKierowcy(15.45, 40, 0.20);

            foreach(var p in pensja)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}