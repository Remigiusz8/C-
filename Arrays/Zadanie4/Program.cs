namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Wprowadź rozmiar tablicy ");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            bool[] tab1 = new bool[n];
            Console.WriteLine();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next();
            }

            for (int j = 0; j < tab1.Length; j++)
            {
                if (tab[j] % 2 == 0)
                {
                    tab1[j] = true;
                } else
                {
                    tab1[j] = false;
                }
            }

            foreach (int k in tab)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            foreach (bool l in tab1)
            {
                Console.WriteLine(l);
            }
        }
    }
}