using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz zdanie: ");
            string sentence = Console.ReadLine();

            string[] sentences = sentence.Split('.', '!', '?');

            foreach (string s in sentences)
            {
                Console.WriteLine(s.Trim());
            }
            Console.WriteLine();

            string[] words = sentence.Split(' ');

            foreach (string a in words)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            foreach (string b in words)
            {
                Console.WriteLine(b.ToUpper());
            }
        }
    }
}
