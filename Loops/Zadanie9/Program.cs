namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok");
            int rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0 && rok % 100 != 0)
            {
                Console.WriteLine("Rok jest przestępny");
            } else if (rok % 400 == 0)
            {
                Console.WriteLine("Rok jest przestępny");
            } else
            {
                Console.WriteLine("Rok jest nieprzestępny");
            }
        }
    }
}