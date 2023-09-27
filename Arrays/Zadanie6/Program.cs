namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Wprowadz wielkosc tablicy: ");
            int n = int.Parse(Console.ReadLine());
            
            double[,] tab = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i,j] = random.NextDouble();
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0:F2} ", tab[j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k == j || k - n+1 == -j)
                        {
                            Console.Write("{0:F2} ", 0);
                        }
                        else
                        {
                            Console.Write("{0:F2} ", tab[j, k]);
                        }
                }
                Console.WriteLine();
            }
        }
    }
}