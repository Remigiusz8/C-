namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Random s = new Random();
            int wylosowanaWartosc = r.Next(999);
            int wylosowanaWartosc2 = s.Next(999);

            Console.WriteLine(wylosowanaWartosc);
            Console.WriteLine(wylosowanaWartosc2);
            Console.WriteLine();

            if (wylosowanaWartosc > wylosowanaWartosc2)
            {
                int zmiennik = wylosowanaWartosc;
                wylosowanaWartosc = wylosowanaWartosc2;
                wylosowanaWartosc2 = zmiennik;
            }

            for (int i = wylosowanaWartosc; i <= wylosowanaWartosc2; i++)
            {
                
            }
            Console.WriteLine("Wartość minimalna zbioru: {0}", wylosowanaWartosc);
            Console.WriteLine("Wartość maksymalna zbioru: {0}", wylosowanaWartosc2);
            Console.WriteLine("Wartość średnia zbioru: {0}", wylosowanaWartosc2 / 2);
        }
    }
}