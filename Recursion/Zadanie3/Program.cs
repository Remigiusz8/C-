namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz cyfrę");
            int liczba = int.Parse(Console.ReadLine());

            Console.WriteLine(Suma(liczba));
        }

        static int Suma(int n) {
            {
                if (n == 0)
                {
                    return 0;
                }

                return (n % 10 + Suma(n / 10));
            } }
    }
}