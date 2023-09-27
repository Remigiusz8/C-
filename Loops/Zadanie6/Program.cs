namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int wynik = j * i;
                    Console.Write(wynik + " ");
                }
                Console.WriteLine();

            }
        }
    }
}