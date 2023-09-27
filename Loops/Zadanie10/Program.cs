using System.Diagnostics.CodeAnalysis;

namespace Zadanie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź cyfrę końcową");
            int koniec = int.Parse(Console.ReadLine());

            int liczba = 0;
            for (int i = 1; i <= koniec; i++)
            {
                if (i + i > 100)
                {
                    liczba += 1;
                }
            }
            Console.WriteLine(liczba);
        }
    }
}