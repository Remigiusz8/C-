using System.ComponentModel.DataAnnotations;

namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 122; i >= 97; i--)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }
}