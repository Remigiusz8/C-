using System.Collections.Generic;
namespace Zadanie6
{
    public class Kolory : IEnumerable<string>
    {
        private string[] teksty;

        public Kolory(params string[] tabParam)
        {
            teksty = new string[tabParam.Length];
            int indeks = 0;

            foreach (string txt in tabParam)
            {
                teksty[indeks++] = txt;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return ((IEnumerable<string>)teksty).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return teksty.GetEnumerator();
        }
    }

    class Glowna
    {
        static void Main(string[] args)
        {
            Kolory k = new Kolory("biały", "czerwony", "żółty", "zielony", "czarny",
            "brązowy");

            foreach (string kolor in k)
            {
                Console.WriteLine(kolor);
            }
            Console.ReadKey();
        }
    }
}