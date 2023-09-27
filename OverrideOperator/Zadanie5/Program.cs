using System.Reflection.Metadata.Ecma335;

namespace Zadanie5
{
    struct Czas
    {
        private int H;
        private int m;

        public Czas(int H, int m)
        {
            if (H > 0 && H < 24)
            {
                this.H = H;
            }
            else { this.H = 0; }

            if (m > 0 && m < 60)
            {
                this.m = m;
            }
            else { this.m = 0; }
        }

        public override string ToString()
        {
            return $"{H}:{m}";
        }

        public static Czas operator + (Czas c1, Czas c2)
        {
            Czas c = new Czas(0, 0);
            int min = c1.m + c2.m;
            int godz = 0;

            if (min >= 60)
            {
                godz += min / 60;
                min = min % 60;
            }

            godz += c1.H + c2.H;

            if (godz >= 24)
            {
                godz = godz % 24;
            }

            c.H = godz;
            c.m = min;
            return c;
        }

        public static Czas operator - (Czas c1, Czas c2)
        {
            Czas c = new Czas(0, 0);
            c.m = c1.m - c2.m;

            if (c.m < 0)
            {
                c.H -= c.m / 60;
                c.m = c.m % 60;
            }

            c.H += c1.H - c2.H;

            if (c.H < 0)
            {
                c.H = 24 - c.H % 24;
            }

            return c;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Czas c1 = new Czas(23, 30);
            Czas c2 = new Czas(1, 30);

            Console.WriteLine(c1.ToString());

            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
        }
    }
}