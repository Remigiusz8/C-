namespace Zadanie1
{
    internal class Program
    {
        public static string Czytaj()
        {
            Console.WriteLine("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia: ");
            string rokUrodzenia = Console.ReadLine();
            Console.WriteLine("Podaj miesiąc urodzenia: ");
            string miesiacUrodzenia = Console.ReadLine();
            Console.WriteLine("Podaj dzień urodzenia: ");
            string dzienUrodzenia = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu: ");
            string numerTelefonu = Console.ReadLine();

            string wiersz = (imie + "; " + nazwisko + "; " + miesiacUrodzenia + "; " + dzienUrodzenia + "; " + numerTelefonu);
            return wiersz;
        }

        public static void Zapisz(string x)
        {
            string sciezka = @"C:\Users\Remek\source\repos\Zadanie1\dane.txt";

            StreamWriter dane;
            if (!File.Exists(sciezka))
            {
                dane = File.CreateText(sciezka);

            }
            else
            {
                dane = new StreamWriter(sciezka, true);

            }
            dane.WriteLine(x);
            dane.Flush();
        }
        static void Main(string[] args)
        {
            
            char odp;
            
            do
            {
                string dane = Czytaj();
                Zapisz(dane);
                Console.WriteLine("Czy chcesz dodać kolejną osobę? (t/n) ");

                odp = Convert.ToChar(Console.ReadLine());
            } while (odp == 't');
        }
    }
}