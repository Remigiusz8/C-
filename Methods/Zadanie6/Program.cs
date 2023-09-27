namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczenie wyrażenia W = (x+1) + (x+2) + ... + (x+n)");
            Console.WriteLine("Podaj n ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(W(n,x));
        }

        static int W(int n, int x)
        {
            int wynik = 0;
            for (int i = 1; i <= n; i++)
            {
                int liczba = x + i;
                wynik += liczba;
            }
            return wynik;
        }
    }
}