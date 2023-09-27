using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace Zadanie1_1
{
    struct Zespolone
    {
        private int a;
        private int b;

        public Zespolone(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return $"{a} + {b}i";
        }

        public override bool Equals(Object a)
        {
            Zespolone zespolone1 = (Zespolone)a;

            if(zespolone1.a != this.a) return false;
            if(zespolone1.b != this.b) return false;
            return true;
        }

        public static Zespolone operator + (Zespolone jeden, Zespolone dwa)
        {
            Zespolone trzy = new Zespolone(0, 0);
            trzy.a = jeden.a + dwa.a;
            trzy.b = jeden.b + dwa.b;
            return trzy;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Zespolone z1 = new Zespolone(2, 7);
            Zespolone z2 = new Zespolone(4, 7);

            Console.WriteLine(z1.ToString());
            Console.WriteLine(z2.ToString());

            Console.WriteLine(Zespolone.Equals(z1, z2));

            Console.WriteLine(z1 + z2);
        }
    }
}