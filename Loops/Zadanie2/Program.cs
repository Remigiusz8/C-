namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tworzenie prostokąta
            
            Console.WriteLine("Podaj szerokosc ");
            int szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc ");
            int wysokosc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= wysokosc; i++)
            {
                Console.Write("*");
                for (int j = 1; j < szerokosc; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /* Tworzenie trójkąta rosnącego
             
            Console.WriteLine("Podaj wysokosc ");
            int wys = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int k = 1; k <= wys; k++)
            {
                Console.Write("*");
                for (int l = 1; l < k; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            // Tworzenie trójkąta rosnącego z drugiej strony

            Console.WriteLine("Podaj wysokosc ");
            int high = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int m = 1; m <= high; m++)
            {
                for (int n = 1; n <= high; n++)
                {
                    if (n > high - m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}