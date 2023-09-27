using System.Security.Cryptography.X509Certificates;

namespace Zadanie2
{
    class Punkt
    {
        private int x { get; set; }
        private int y { get; set; }

        public Punkt() { x = 0; y = 0; }

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Przesun(int a, int b)
        {
            x += a;
            y += b;
        }

        public override string ToString()
        {
            return $"x = {x}\ny = {y}";
        }

        public void Wyswietl()
        {
            Console.WriteLine(this.ToString());
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p = new Punkt(2, 5);

            p.Wyswietl();
            Console.WriteLine();
            p.Przesun(-2, 4);
            p.Wyswietl();
        }
    }
}