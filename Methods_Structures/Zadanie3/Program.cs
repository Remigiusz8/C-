using System.Numerics;
using System.Runtime.CompilerServices;

namespace Zadanie3
{
    
    class Wektor
    {
        private int x { get; set; }

        public Wektor(int x)
        {
            this.x = x;
        }

        public Wektor(Wektor copy)
        {
            this.x = copy.x;
        }

        public void Elementy()
        {
            Console.WriteLine($"{x} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wektor[] wektor = new Wektor[3];

            wektor[0] = new Wektor(2);
            wektor[1] = new Wektor(0);
            wektor[2] = new Wektor(-3);

            Wektor[] vect = new Wektor[3];

            vect[0] = new Wektor(-1);
            vect[1] = new Wektor(-1);
            vect[2] = new Wektor(5);
        }
    }
}