namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 5;
            double sin = 0.5;
            double R = c / 2;
            int r = 1;
            Console.WriteLine(Pole(a, b));
            Console.WriteLine(Pole(b, c, sin));
            Console.WriteLine(Pole(a,b,c,R));
            Console.WriteLine(Pole(a, b, c, r));
        }

        static double Pole(int a, int h)
        {
            return 0.5 * a * h;
        }

        static double Pole(int a, int b, double sinus)
        {
            return 0.5 * a * b * sinus;
        }

        static double Pole(int a, int b, int c, double R)
        {
            return (a * b * c) / (4 * R);
        }
        
        static double Pole(int a, int b, int c, int r)
        {
            return r * (a + b + c) / 2;
        }
    }
}