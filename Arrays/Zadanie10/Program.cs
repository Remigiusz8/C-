using System.ComponentModel;

namespace Zadanie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz zdanie: ");
            string word = Console.ReadLine();
            Console.WriteLine();
            string[] tab = word.Split(' ');

            foreach(string s in tab)
            {
                Console.WriteLine(s);
            }         
        }
    }
}