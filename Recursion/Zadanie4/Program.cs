namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            
        }

        static string Reversed(string z)
        {
            char[] signs = z.ToCharArray();

            if (signs.Length == 0)
            {
                return z;
            }
            signs.Reverse();
            
        }
    }
}