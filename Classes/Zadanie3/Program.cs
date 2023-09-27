using System.Net.Http.Headers;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt[] tab = new Punkt[3];

            tab[0] = new Punkt(1, 1);
            tab[1] = new Punkt(2, 2);
            tab[2] = new Punkt(3, 3);

            foreach (Punkt a in tab)
            {
                a.Wyswietl();
            }
            Console.WriteLine(Punkt.NaProstej(tab));
        }
    }
}