using System.Data;

namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Ilość wierszy: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ilość kolumn: ");
            int n = int.Parse(Console.ReadLine());
            double[,] tab = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i, j] = random.NextDouble();
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0:F2} ",tab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transponowana tablica:");
            Transpozycja(tab);
            Console.WriteLine("Suma wierszy to: {0}", SumaWierszy(tab));
            Console.WriteLine("Suma kolumn to: {0}", SumaKolumn(tab));
        }

        static double[,] Transpozycja(double[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write("{0:F2} ",tablica[j, i]);
                }
                Console.WriteLine();
            }
            return tablica;
        }

        static double SumaWierszy(double[,] tablica)
        {
            double wiersze = 0;
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    wiersze += tablica[i,j];
                }
            }
            return wiersze;
        }

        static double SumaKolumn(double[,] tablica)
        {
            double kolumny = 0;
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    kolumny += tablica[j, i];
                }
            }
            return kolumny;
        }
    }
}