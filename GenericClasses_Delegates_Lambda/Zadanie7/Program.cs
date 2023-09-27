using System.Threading.Channels;

namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> wyswietl = a => Console.WriteLine(a);

            wyswietl("Jakub");
            wyswietl("jeden");
            wyswietl("Paweł");
        }
    }
}