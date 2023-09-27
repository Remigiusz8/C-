namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz n: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Dla {0}, wartość wynosi {1}",n, Ciag(n));
        }

        static double Ciag(double liczba)
        {
            if (liczba == 1)
            {
                return 1;
            } else if (liczba == 2)
            {
                return 0.5;
            } else if (liczba > 2)
            {
                return -(Ciag(liczba-1) * Ciag(liczba-2));
            } else
            {
                return 0;
            }
        }
    }
}