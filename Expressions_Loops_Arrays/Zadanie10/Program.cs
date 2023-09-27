namespace Zadanie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wpisz cyfrę");
                int n = int.Parse(Console.ReadLine());
                int liczba = 1;

                for (int i = 1; i <= n; i++)
                {
                    if (n < 0)
                    {
                        Console.WriteLine("Nieprawidłowa wartość!");
                        break;
                    }
                    else if (n == 1 || n == 0)
                    {
                        Console.WriteLine(1);
                        break;
                    }
                    else
                    {
                        liczba *= i;
                    }
                }
                Console.WriteLine("Silnia z liczby {0} wynosi {1}.", n, liczba);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //do poprawy
        }
    }
}