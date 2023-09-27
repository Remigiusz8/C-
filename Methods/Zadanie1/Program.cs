namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Podaj długość tablicy: ");
            int len = int.Parse(Console.ReadLine());
            double[] liczby = new double[len];
            Console.WriteLine();

            for (int i = 0; i < len; i++)
            {
                liczby[i] = random.NextDouble();
                Console.WriteLine("{0}", liczby[i]);
            }
            Console.WriteLine();
            Console.WriteLine("największa wartość {0}", HighestValue(liczby));
            Console.WriteLine("Indeks najmniejszego elementu {0}", MinimumIndex(liczby));
            Console.WriteLine("Średnia {0}", Average(liczby));

        }

        static double HighestValue(double[] tablica)
        {
            int max = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[max] < tablica[i])
                {
                    max = i;
                }
            }
            return tablica[max];
        }
        static double MinimumIndex(double[] tablica)
        {
            int min = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[min] > tablica[i])
                {
                    min = i;
                }
            }
            return min;
        }

        static double Average(double[] tablica)
        {
            double sum = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                sum += tablica[i];
            }
            double avg = sum / tablica.Length;
            return avg;
        }
    }
}