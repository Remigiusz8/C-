using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Func<Random, int> generowanie = r => r.Next(1,101);
            Func<int, int, int> dodaj = (a,b) => a + b;

            Console.WriteLine(generowanie(r));
            Console.WriteLine(dodaj(3,6));
        }
    }
}