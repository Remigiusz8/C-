namespace Zadanie2
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
            return $"{imie} {nazwisko}\t{stawkaGodzinowa.ToString("0.00")}\t{liczbaGodzinPracy.ToString("0.00")}\t{(stawkaGodzinowa*liczbaGodzinPracy).ToString("0.00")}";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik jan = new Pracownik("Jan","Kowalski",20,160);
            Pracownik piotr = new Pracownik("Piotr","Nowak",30,120);
            Console.WriteLine(jan.ToString());
            Console.WriteLine(piotr.ToString());
        }
    }
}