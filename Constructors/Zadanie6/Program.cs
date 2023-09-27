using System.Linq.Expressions;

namespace Zadanie6
{
    class Pracownik
    {
        private string imie { get; set; }
        private string nazwisko { get; set; }
        private int stawkaGodzinowa { get; set; }
        private int liczbaGodzinPracy { get; set; }

        public Pracownik(string imie, string nazwisko, int stawkaGodzinowa, int liczbaGodzinPracy)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.liczbaGodzinPracy = liczbaGodzinPracy;
        }

        public override string ToString()
        {
            return $"{imie} {nazwisko}\t{stawkaGodzinowa.ToString("0.00")}\t{liczbaGodzinPracy.ToString("0.00")}\t{(stawkaGodzinowa * liczbaGodzinPracy).ToString("0.00")}";
        }

        public override bool Equals(Object pracownik)
        {
            Pracownik pracownik1 = (Pracownik)pracownik;

            if (imie != pracownik1.imie) return false;
            if (nazwisko !=  pracownik1.nazwisko) return false;
            if (stawkaGodzinowa != pracownik1.stawkaGodzinowa) return false;
            if (liczbaGodzinPracy != pracownik1.stawkaGodzinowa) return false;
            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik jan = new Pracownik("Jan", "Kowalski", 20, 160);
            Pracownik piotr = new Pracownik("Piotr", "Nowak", 30, 120);
            Pracownik stefan = new Pracownik("Piotr", "Nowak", 30, 120);
            Console.WriteLine(jan.ToString());
            Console.WriteLine(piotr.ToString());

            Console.WriteLine(piotr.Equals(jan));
            Console.WriteLine(jan.Equals(stefan));
            Console.WriteLine(jan.Equals(jan));
        }
    }
}