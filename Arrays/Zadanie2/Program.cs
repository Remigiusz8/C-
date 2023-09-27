namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy ");
            int len = int.Parse(Console.ReadLine());

            int[] tab1 = new int[len];

            Random random = new Random();

            for (int i = 0; i < len; i++)
            {
                tab1[i] = random.Next();
            }
            
            foreach (int k in tab1)
            {
                Console.Write(k + ", ");
            }
            Console.WriteLine();
            int index = 0;
            int minimum = tab1[0];

            for (int j = 1; j < len; j++)
            {
                if (tab1[j] <= minimum)
                {
                    minimum = tab1[j];
                    index = j;
                }
            }
            Console.WriteLine("Minimum: {0}, Index: {1}", minimum, index);
        }
    }
}