namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double srednia; 
            int min = 1, max = 1;
            Random r = new Random();
            Console.WriteLine("Wprowadź rozmiar tablicy ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double[] tab = new double[n];

            for (int i = 0; i < n; i++)
            {
                double x = r.NextDouble();
                tab[i] = x;
            }
            
            foreach (double j in tab)
            {
                Console.Write(j + "  ");
                suma += j;
            }
            srednia = suma / n;
            Console.WriteLine("\n\nSuma wynosi: {0}", suma);
            Console.WriteLine("Srednia wynosi: {0}", srednia);

            for (int k = 0; k < tab.Length; k++)
            {
                if (tab[k] > tab[max])
                {
                    max = k;
                }

                if (tab[k] < tab[min])
                {
                    min = k;
                }
            }
            Console.WriteLine("Wartość maksymalna: " + tab[max]);
            Console.WriteLine("Wartość minimalna: " + tab[min]);

            
            

            
        }
    }
}