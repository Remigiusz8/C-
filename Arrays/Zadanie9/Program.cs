using System.Net.Http.Headers;

namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Podaj liczbę wierszy: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę wierszy: ");
            int m = int.Parse(Console.ReadLine());

            double[,] tab = new double[n, m];
            double[,] upTab = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tab[i, j] = r.NextDouble();
                    upTab[i, j] = tab[i, j];
                }
            }

            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0:F2} ", tab[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int k = 0; k < tab.GetLength(0); k++)
                    {
                        for (int l = 0; l < tab.GetLength(1); l++)
                        {
                            if (tab[i, j] < tab[k, l])
                            {
                                double temp = tab[i, j];
                                tab[i, j] = tab[k, l];
                                tab[k, l] = temp;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Posortowana tablica");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0:F2} ", tab[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}