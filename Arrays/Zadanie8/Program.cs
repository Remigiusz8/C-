using System.ComponentModel;

namespace Zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Podaj ilość wierszy: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Podaj ilość kolumn: ");
            int m = int.Parse(Console.ReadLine());
            double suma = 0;

            double[,] tab = new double[n, m];
            double[,] sumaTab = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tab[i, j] = r.NextDouble();
                    sumaTab[i, j] = tab[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                suma = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0:F2} ", tab[i, j]);
                    suma += tab[i, j];
                }
                Console.Write(" Suma = {0:F2} ", suma);
                Console.WriteLine();
                
            }
        }
    }
}