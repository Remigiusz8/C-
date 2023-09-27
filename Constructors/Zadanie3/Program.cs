namespace Zadanie3{
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
            return $"{imie} {nazwisko}\t\t{stawkaGodzinowa.ToString("0.00")}\t{liczbaGodzinPracy.ToString("0.00")}\t{(stawkaGodzinowa * liczbaGodzinPracy).ToString("0.00")}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownicy = new Pracownik[4];

            pracownicy[0] = new Pracownik("Jan", "Kowalski", 20, 160);
            pracownicy[1] = new Pracownik("Anna", "Nowak", 25, 140);
            pracownicy[2] = new Pracownik("Jerzy", "Adamski", 15, 170);
            pracownicy[3] = new Pracownik("Ewa", "Czekaj", 17, 150);

            foreach(Pracownik p in pracownicy)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}