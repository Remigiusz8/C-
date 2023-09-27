using System.Diagnostics.CodeAnalysis;

namespace Zadanie1
{
    struct Zespolone
    {
        int re, im;

        public Zespolone(int re, int im)
        {
            this.re = re;
            this.im = im;
        }
        public int getIm() { return im; }
        public int getRe() { return re; }
        public override string ToString()
        {
            return $"Liczba zespolona: {re} + {im}i";
        }
        public override bool Equals(Object zespolona)
        {
            Zespolone zespolona1 = (Zespolone)zespolona;

            if((re != zespolona1.re) && (im != zespolona1.im))
            {
                return false;
            } else
            {
                return true;
            }
        }

        public static Zespolone operator + (Zespolone z1, Zespolone z2)
        {
            return new Zespolone(z1.re + z2.re, z1.im + z2.im);
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Zespolone z1 = new Zespolone(1,2);
            Zespolone z2 = new Zespolone(4,6);

            Console.WriteLine(z1 + z2);
        }
    }
}