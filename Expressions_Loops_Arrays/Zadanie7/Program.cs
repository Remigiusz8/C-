using System;

namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Podaj ilość wierszy: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość wierszy: ");
            int m = int.Parse(Console.ReadLine());
            int[,] tab = new int[n,m];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tab[i,j] = random.Next(100);
                    Console.Write("{0} ", tab[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Wybierz wiersz ");
            int w1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz wiersz drugi: ");
            int w2 = int.Parse(Console.ReadLine());
            int[] temp = new int[m];
            int tmp;

            for (int i = 0; i < n; i++)
            {
                if (i == w1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        temp[j] = tab[i, j];
                        Console.Write("{0} ",temp[j]);
                        //Console.WriteLine(tab[n, m]);
                    }
                }
                if (i == w2)
                {
                    for (int j = 0; j < m; j++)
                    {
                        tmp = tab[i, j];
                        tab[i, j] = tmp;
                        Console.Write("{0} ", temp[j]);
                        //Console.WriteLine(tab[n, m]);
                    }
                }
            }
            
        }
    }
}