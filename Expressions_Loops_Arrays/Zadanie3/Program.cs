namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                Console.WriteLine("Podaj rozmiar macierzy ");
                int n = int.Parse(Console.ReadLine());
                int[,] tab = new int[n, n];
                int suma = 0;

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
                        if (j == i)
                        {
                            suma += tab[i, j];
                        }
                    }
                }
                Console.WriteLine();
                Console.Write("Suma liczb na głównej przekątnej wynosi {0}", suma);
            }
            catch (Exception x)
            {
                Console.Write(x.Message);
            }
        }
    }
}