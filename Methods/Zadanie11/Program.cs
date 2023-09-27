namespace Zadanie11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(obwodPole(9));
            Console.WriteLine(obwodPole(2, 6));
            Console.WriteLine(obwodPole(3, 5, 4));
        }

        static bool obwodPole(double a)
        {

            bool possible = true;

            if (a <= 0)
            {
                possible = false;
            }
            else
            {
                double pole = a * a;
                double obwod = 4 * a;
                Console.WriteLine("Pole kwadratu wynosi: {0}", pole);
                Console.WriteLine("Obwód kwadratu wynosi: {0}", obwod);
            }

            return possible;

        }

        static bool obwodPole(double a, double b)
        {

            bool possible = true;

            if (a <= 0 || b <= 0)
            {
                possible = false;
            }
            else
            {
                double pole = a * b;
                double obwod = 2 * a + 2 * b;
                Console.WriteLine("Pole prostokąta wynosi: {0}", pole);
                Console.WriteLine("Obwód prostokąta wynosi: {0}", obwod);
            }

            return possible;
        }

        static bool obwodPole(double a, double b, double c)
        {

            bool possible = true;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                possible = false;
            }
            else if (a + b <= c || a + c <= b || b + c <= a)
            {
                possible = false;

            }
            else
            {
                double p = (a + b + c) / 2;
                double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                double obwod = a + b + c;
                Console.WriteLine("Pole trójkąta wynosi: {0}", pole);
                Console.WriteLine("Obwód trójkąta wynosi: {0}", obwod);
            }

            return possible;
        }
    }
}