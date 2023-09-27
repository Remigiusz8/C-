namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź k");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWynik symbolu Newtona wynosi {0}", Newton(n, k));
        }

        static int Newton(int n, int k)
        {
            if (n < k)
            {
                return 0;
            } else if (n == k)
            {
                return 1;
            } else
            {
                return ((Silnia(n)) / ((Silnia(k)) * Silnia(n - k)));
            }
        }

        static int Silnia(int liczba)
        {
            if (liczba == 0 || liczba == 1)
            {
                return 1;
            } else
            {
                return (liczba * Silnia(liczba - 1));
            }
        }
    }
}