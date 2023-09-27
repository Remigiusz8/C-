namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Podaj rozmiar: ");
            int n = int.Parse(Console.ReadLine());
            int[,] tab = new int[n, n];
            int min = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", tab[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        if (tab[i,j] < min)
                        {
                            min = tab[i, j];
                        }
                        //if (tab[i,j] < tab[i, j + 1])
                        //{
                        //    min = tab[i, j];
                        //} else
                        //{
                        //    min = tab[i, j + 1];
                        //}
                    } else if (i > j)
                    {
                        if (max < tab[i, j])
                        {
                            max = tab[i, j];
                        }
                        //if (tab[i, j] > tab[i + 1, j])
                        //{
                        //    max = tab[i, j];
                        //} else
                        //{
                        //    max = tab[i + 1, j];
                        //}
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Wartość minimalna nad główną przekątną {0}", min);
            Console.WriteLine("Wartość maksymalna pod główną przekątną {0}", max);
            Console.WriteLine("{0}", min == max);
        }
    }
}