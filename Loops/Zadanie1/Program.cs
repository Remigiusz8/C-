namespace Zadanie1
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Podaj pierwsza cyfre przedziału: ");
            int pierwsza = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ostatnią cyfre przedziału: ");
            int druga = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = pierwsza; i <= druga; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            while (pierwsza <= druga)
            {
                if (pierwsza % 2 == 0 && pierwsza % 3 == 0)
                {
                    Console.WriteLine(pierwsza);
                }
                pierwsza++;
            }
            Console.WriteLine();
            Console.WriteLine();

            int j = pierwsza - 1;
            do
            {

                j++;
                if (j % 2 == 0 && j % 3 == 0)
                {
                    Console.WriteLine(j);
                }

            } while (j + 1 <= druga);

        }
    }
}