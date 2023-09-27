namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Podaj liczbę wierszy: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn: ");
            int m = int.Parse(Console.ReadLine());

            int[,] tab = new int[n, m];
            int[,] newTab = new int[n, m];
            int[,] tabT = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tab[i, j] = random.Next(100);
                    newTab[i, j] = tab[i, j];
                    tabT[j, i] = tab[i, j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", tab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Podaj liczbę przez którą macierz będzie mnożona ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ",c * newTab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Transpozycja macierzy");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", tab[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}